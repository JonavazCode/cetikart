using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using ExitGames.Client.Photon;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    [Header("Error's text")]
    public Text GameNameText;
    public Text RoomNameText;
    public Text PassNameText;
    public Text PlayNameText;
    public Text GameModeText;
    public Text WarningText;
    public Text JoinRoomNameText;
    public Text JoinPassNameText;
    public Text JoinWarningText;

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
    public string GameMode;

    [Header("Inside Room Panel")]
    public GameObject InsideRoomUIPanel;
    public Text RoomInfoText;
    public GameObject PlayerListPrefab;
    public GameObject PlayerListContent;
    public GameObject StartGameButton;
    public Text GameMapText;
    public Image PanelBackground;
    public Sprite GimnasioBackground;
    public Sprite BaniosBackground;


    [Header("Join Random Room Panel")]
    public GameObject JoinRandomRoomUIPanel;
    public InputField JoinRoomNameInputField;
    public InputField JoinPasswordInputField;


    private Dictionary<int, GameObject> playerListGameObjects;

    [Header("Mexicanadas")]
    public int MapCounter;
    private bool SegundoMapa = false;

    #region Unity Methods
    // Start is called before the first frame update
    void Start()
    {
        if (DBManager.LoggedIn)
        {
            PlayerNameInput.text = DBManager.nickname;
        }
        MapCounter = 1;
        ActivatePanel(LoginUIPanel.name);

        PhotonNetwork.AutomaticallySyncScene = true;
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
        if (string.IsNullOrEmpty(RoomNameInputField.text) || string.IsNullOrEmpty(MaxPlayersInputField.text) || string.IsNullOrEmpty(PasswordInputField.text) || (GameMode != "1" && GameMode != "2"))
        {
            
            RoomNameText.text = string.IsNullOrEmpty(RoomNameInputField.text)? "Rellenar ->": "Numero sala";
            PlayNameText.text = string.IsNullOrEmpty(MaxPlayersInputField.text) ? "Rellenar ->" : "Num de jug (max. 8)";
            PassNameText.text = string.IsNullOrEmpty(PasswordInputField.text) ? "Rellenar ->" : "Password";
            GameModeText.text = (GameMode != "1" && GameMode != "2") ? "Rellenar ->" : "Mapa";
        }
        else
        {
            ActivatePanel(CreatingRoomInfoUIPanel.name);
            string roomName = RoomNameInputField.text;
            int maxPlayers = int.Parse(MaxPlayersInputField.text);
            if (maxPlayers > 8)
                maxPlayers = 8;
            string pass = PasswordInputField.text;
           /* if (!string.IsNullOrEmpty(roomName))
            {
                roomName = "Room" + Random.Range(100, 1000);
            }
            */
            RoomOptions roomOptions = new RoomOptions();
            roomOptions.MaxPlayers = (byte)(maxPlayers);

            //ns = nombre sala
            //ps = password sala
            //m = map
            string[] roomPropsInLobby = { "ns", "ps", "m" };

            ExitGames.Client.Photon.Hashtable customRoomProperties = new ExitGames.Client.Photon.Hashtable() { { "ns", roomName }, { "ps", pass }, {"m", GameMode} };
            roomOptions.CustomRoomPropertiesForLobby = roomPropsInLobby;
            roomOptions.CustomRoomProperties = customRoomProperties;

            PhotonNetwork.CreateRoom(roomName, roomOptions);
        }

    }

    public void OnJoinRoomButtonClicked()
    {
        if (string.IsNullOrEmpty(JoinRoomNameInputField.text) || string.IsNullOrEmpty(JoinPasswordInputField.text))
        {
            JoinRoomNameText.text = string.IsNullOrEmpty(JoinRoomNameInputField.text) ? "Rellenar ->" : "Numero sala";
            JoinPassNameText.text = string.IsNullOrEmpty(JoinPasswordInputField.text) ? "Rellenar ->" : "Password";
        }
        else
        {
            string joinRoomName = JoinRoomNameInputField.text;
            string joinPassName = JoinPasswordInputField.text;

            ExitGames.Client.Photon.Hashtable expectedCustomRoomProperties = new ExitGames.Client.Photon.Hashtable() { {"ns", joinRoomName }, {"ps", joinPassName }, { "m", MapCounter.ToString()} };
            PhotonNetwork.JoinRandomRoom(expectedCustomRoomProperties, 0);
        }
    }
    public void OnBackButtonClicked()
    {
        ActivatePanel(GameOptionsUIPanel.name);
    }

    public void OnLeaveGameButtonClicked()
    {
        PhotonNetwork.LeaveRoom();
    }

    public void OnStartGameButtonClicked()
    {
        if (PhotonNetwork.CurrentRoom.CustomProperties.ContainsKey("m"))
        {
            if (PhotonNetwork.CurrentRoom.CustomProperties.ContainsValue("1"))
            {
                //gimnasio
                PhotonNetwork.LoadLevel("Gimnasio 1");

            }
            else if (PhotonNetwork.CurrentRoom.CustomProperties.ContainsValue("2"))
            {
                //banio
                PhotonNetwork.LoadLevel("Baños 1");
            }
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
        ActivatePanel(InsideRoomUIPanel.name);


        Debug.Log(PhotonNetwork.LocalPlayer.NickName + " has joined to: " + PhotonNetwork.CurrentRoom.Name);
        Debug.LogFormat("Número de jugadores en la sala: {0}", PhotonNetwork.CurrentRoom.PlayerCount);

        if (PhotonNetwork.CurrentRoom.CustomProperties.ContainsKey("ns") && PhotonNetwork.CurrentRoom.CustomProperties.ContainsKey("ps") && PhotonNetwork.CurrentRoom.CustomProperties.ContainsKey("m"))
        {

            RoomInfoText.text = "Número de sala: " + PhotonNetwork.CurrentRoom.Name +
                "  Players/Max.Players: " + PhotonNetwork.CurrentRoom.PlayerCount + "/" + PhotonNetwork.CurrentRoom.MaxPlayers;

            if (PhotonNetwork.CurrentRoom.CustomProperties.ContainsValue("1"))
            {
                //mapa gimnasio
                GameMapText.text = "Gimnasio!";
                PanelBackground.sprite = GimnasioBackground;
            }
            else if (PhotonNetwork.CurrentRoom.CustomProperties.ContainsValue("2"))
            {
                GameMapText.text = "Baños!";
                PanelBackground.sprite = BaniosBackground;
            }


            if (playerListGameObjects == null)
                playerListGameObjects = new Dictionary<int, GameObject>();

            
            foreach (Player player in PhotonNetwork.PlayerList)
            {
                GameObject playerListGameObject = Instantiate(PlayerListPrefab);
                playerListGameObject.transform.SetParent(PlayerListContent.transform);
                playerListGameObject.transform.localScale = Vector3.one;
                playerListGameObject.GetComponent<PlayerListEntryInitializer>().Initialize(player.ActorNumber, player.NickName);

                object isPlayerReady;
                if (player.CustomProperties.TryGetValue(MultiplayerRacingGame.PLAYER_READY, out isPlayerReady))
                {
                    playerListGameObject.GetComponent<PlayerListEntryInitializer>().SetPlayerReady((bool)isPlayerReady);
                }


                playerListGameObjects.Add(player.ActorNumber, playerListGameObject);
            }

        }

        StartGameButton.SetActive(false);
    }
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {

        RoomInfoText.text = "Número de sala: " + PhotonNetwork.CurrentRoom.Name +
            "  Players/Max.Players: " + PhotonNetwork.CurrentRoom.PlayerCount + "/" + PhotonNetwork.CurrentRoom.MaxPlayers;

        GameObject playerListGameObject = Instantiate(PlayerListPrefab);
        playerListGameObject.transform.SetParent(PlayerListContent.transform);
        playerListGameObject.transform.localScale = Vector3.one;
        playerListGameObject.GetComponent<PlayerListEntryInitializer>().Initialize(newPlayer.ActorNumber, newPlayer.NickName);

        playerListGameObjects.Add(newPlayer.ActorNumber, playerListGameObject);

        StartGameButton.SetActive(checkPlayersReady());
    }

    public override void OnPlayerPropertiesUpdate(Player targetPlayer, ExitGames.Client.Photon.Hashtable changedProps)
    {
        GameObject playerListGameObject;
        if (playerListGameObjects.TryGetValue(targetPlayer.ActorNumber, out playerListGameObject))
        {
            object isPlayerReady;
            if (changedProps.TryGetValue(MultiplayerRacingGame.PLAYER_READY, out isPlayerReady))
            {

                playerListGameObject.GetComponent<PlayerListEntryInitializer>().SetPlayerReady((bool)isPlayerReady);

            }



        }

        StartGameButton.SetActive(checkPlayersReady());
    }
    public override void OnPlayerLeftRoom(Player otherPlayer)
    {

        RoomInfoText.text = "Número de sala: " + PhotonNetwork.CurrentRoom.Name +
            "  Players/Max.Players: " + PhotonNetwork.CurrentRoom.PlayerCount + "/" + PhotonNetwork.CurrentRoom.MaxPlayers;

        Destroy(playerListGameObjects[otherPlayer.ActorNumber].gameObject);
        playerListGameObjects.Remove(otherPlayer.ActorNumber);

        StartGameButton.SetActive(checkPlayersReady());
    }

    public override void OnLeftRoom()
    {
        ActivatePanel(GameOptionsUIPanel.name);

        foreach (GameObject playerListGameObject in playerListGameObjects.Values)
        {
            Destroy(playerListGameObject);
        }
        playerListGameObjects.Clear();
        playerListGameObjects = null;
    }

    public override void OnMasterClientSwitched(Player newMasterClient)
    {
        if (PhotonNetwork.LocalPlayer.ActorNumber == newMasterClient.ActorNumber)
        {
            StartGameButton.SetActive(checkPlayersReady());
        }
    }
    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        if (returnCode == 32766)
        {
            ActivatePanel(CreateRoomUIPanel.name);
            WarningText.text = "Cambiar número de sala!";
        }

    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.LogFormat("Código {0}: {1} ", returnCode, message);
        if (returnCode == 32760 && !SegundoMapa)
        {
            string joinRoomName = JoinRoomNameInputField.text;
            string joinPassName = JoinPasswordInputField.text;
            MapCounter++;
            SegundoMapa = true;
            ExitGames.Client.Photon.Hashtable expectedCustomRoomProperties = new ExitGames.Client.Photon.Hashtable() { { "ns", joinRoomName }, { "ps", joinPassName }, { "m", MapCounter.ToString() } };
            PhotonNetwork.JoinRandomRoom(expectedCustomRoomProperties, 0);
        }
        if (returnCode == 32760 && SegundoMapa)
        {
            JoinWarningText.text = "Partida no encontrada!";
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
        InsideRoomUIPanel.SetActive(InsideRoomUIPanel.name.Equals(panelNameToBeActivated));
    }

    public void SetGameMode(string _gameMode)
    {
        GameMode = _gameMode;
    }


    #endregion

    #region Private Methods
    private bool checkPlayersReady()
    {
        if (!PhotonNetwork.IsMasterClient)
        {
            return false;
        }
        foreach (Player player in PhotonNetwork.PlayerList)
        {
            object isPlayerReady;
            if (player.CustomProperties.TryGetValue(MultiplayerRacingGame.PLAYER_READY, out isPlayerReady))
            {
                if (!(bool)isPlayerReady)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        return true;
    }

    #endregion

}
