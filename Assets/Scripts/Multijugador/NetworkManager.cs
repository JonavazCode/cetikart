using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    [Header("Error's text")]
    public Text GameNameText;
    public Text RoomNameText;

    [Header("Loggin UI")]
    public GameObject LoginUIPanel;
    public InputField PlayerNameInput;
    

    [Header("Connecting Info Panel")]
    public GameObject ConnectingInfoUIPanel;

    [Header("Creating Room Info Panel")]
    public GameObject CreatingRoomInfoUIPanel;

    [Header("GameOptions  Panel")]
    public GameObject GameOptionsUIPanel;


    [Header("Create Room Panel")]
    public GameObject CreateRoomUIPanel;
    public InputField RoomNameInputField;
    public InputField MaxPlayersInputField;
    public InputField PasswordInputField;

    [Header("Inside Room Panel")]
    public GameObject InsideRoomUIPanel;


    [Header("Join Random Room Panel")]
    public GameObject JoinRandomRoomUIPanel;

    #region Unity Methods
    // Start is called before the first frame update
    void Start()
    {
        if (DBManager.LoggedIn)
        {
            PlayerNameInput.text = DBManager.nickname;
        }
        ActivatePanel(LoginUIPanel.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #endregion

    #region UI Callbacks Methods
    public void OnLogginButtonClicked()
    {
        string playerName = PlayerNameInput.text;
        if (!string.IsNullOrEmpty(playerName))
        {
            ActivatePanel(ConnectingInfoUIPanel.name);
            if (!PhotonNetwork.IsConnected)
            {
                PhotonNetwork.LocalPlayer.NickName = playerName;
                PhotonNetwork.ConnectUsingSettings();
            }
        }
        else
            Debug.Log("Player name is invalid");
    }

    public void OnCancelButtonClicked()
    {
        ActivatePanel(GameOptionsUIPanel.name);  
    }

    public void OnCreateRoomButtonClicked()
    {
        if (string.IsNullOrEmpty(RoomNameInputField.text))
        {
            RoomNameText.text = "Rellenar Campos!";
        }
        else
        {
            string roomName = RoomNameInputField.text;
            int maxPlayers = int.Parse(MaxPlayersInputField.text);
            if (maxPlayers > 8)
                maxPlayers = 8;
            string pass = PasswordInputField.text;
            if (!string.IsNullOrEmpty(roomName))
            {
                roomName = "Room" + Random.Range(100, 1000);
            }

            RoomOptions roomOptions = new RoomOptions();
            roomOptions.MaxPlayers = (byte)(maxPlayers);

            //ns = nombre sala
            //ps = password sala
            string[] roomPropsInLobby = { "ns", "ps" };

            ExitGames.Client.Photon.Hashtable customRoomProperties = new ExitGames.Client.Photon.Hashtable() { { "ns", roomName }, { "ps", pass } };
            roomOptions.CustomRoomPropertiesForLobby = roomPropsInLobby;
            roomOptions.CustomRoomProperties = customRoomProperties;

            PhotonNetwork.CreateRoom(roomName, roomOptions);
        }

    }
    #endregion

    #region Photon Callbacks

    public override void OnConnected()
    {
        Debug.Log("Conectado a internet con el método OnConnected!");
    }

    public override void OnConnectedToMaster()
    {
        ActivatePanel(GameOptionsUIPanel.name);
        Debug.LogFormat("{0} Se ha conectado al servidor de Photon!", PhotonNetwork.LocalPlayer.NickName);
    }


    public override void OnCreatedRoom()
    {
        Debug.Log(PhotonNetwork.CurrentRoom.Name + " has been created");
    }

    public override void OnJoinedRoom()
    {
        Debug.Log(PhotonNetwork.LocalPlayer.NickName + " has joined to: " + PhotonNetwork.CurrentRoom.Name);

        if (PhotonNetwork.CurrentRoom.CustomProperties.ContainsKey("ns") && PhotonNetwork.CurrentRoom.CustomProperties.ContainsKey("ps"))
        {
            object nombreSala;
            object passSala;
            if (PhotonNetwork.CurrentRoom.CustomProperties.TryGetValue("ns", out nombreSala))
            {
                Debug.Log(nombreSala.ToString());
            }
            if (PhotonNetwork.CurrentRoom.CustomProperties.TryGetValue("ps", out passSala))
            {
                Debug.Log(passSala.ToString());
            }
        }
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        try
        {
            GameNameText.text = "Sin conexion a internet";
        }
        catch (MissingReferenceException)
        { 
            
        }
    }

    #endregion

    #region Public Methods
    public void ActivatePanel(string panelNameToBeActivated)
    {
        LoginUIPanel.SetActive(LoginUIPanel.name.Equals(panelNameToBeActivated));
        ConnectingInfoUIPanel.SetActive(ConnectingInfoUIPanel.name.Equals(panelNameToBeActivated));
        CreatingRoomInfoUIPanel.SetActive(CreatingRoomInfoUIPanel.name.Equals(panelNameToBeActivated));
        CreateRoomUIPanel.SetActive(CreateRoomUIPanel.name.Equals(panelNameToBeActivated));
        GameOptionsUIPanel.SetActive(GameOptionsUIPanel.name.Equals(panelNameToBeActivated));
        JoinRandomRoomUIPanel.SetActive(JoinRandomRoomUIPanel.name.Equals(panelNameToBeActivated));
    }
    #endregion

}
