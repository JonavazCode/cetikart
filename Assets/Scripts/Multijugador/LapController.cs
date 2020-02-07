using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using ExitGames.Client.Photon;
using UnityEngine.UI;
public class LapController : MonoBehaviourPun
{
    public List<GameObject> Checkpoints = new List<GameObject>();
    public int NumeroCheckpointActual;
    public enum RaiseEventsCode
    { 
        WhoFinishedEventCode = 0
    }
    private int finishOrder = 0;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject checkpoint in RacingModeGameManager.instance.Checkpoints)
        {
            Checkpoints.Add(checkpoint);
        }
    }

    private void OnEnable()
    {
        PhotonNetwork.NetworkingClient.EventReceived += OnEvent;
    }

    private void OnDisable()
    {
        PhotonNetwork.NetworkingClient.EventReceived -= OnEvent;
    }

    void OnEvent(EventData photonEvent)
    {
        if (photonEvent.Code == (byte)RaiseEventsCode.WhoFinishedEventCode)
        {
            object[] data = (object[])photonEvent.CustomData;

            string nickNameOfFinishedPlayer = (string)data[0];

            finishOrder = (int)data[1];

            int viewID = (int)data[2];

            Debug.Log(nickNameOfFinishedPlayer + " " + finishOrder);

            GameObject orderUITextGameObject = RacingModeGameManager.instance.FinishedOrderUIGameObjects[finishOrder - 1];
            orderUITextGameObject.SetActive(true);

            if (viewID == photonView.ViewID)
            {
                //el jugador actual soy yo
                orderUITextGameObject.GetComponent<Text>().text = finishOrder + ", " + nickNameOfFinishedPlayer;
                orderUITextGameObject.GetComponent<Text>().color = Color.red;


            }
            else
            {
                orderUITextGameObject.GetComponent<Text>().text = finishOrder + ", " + nickNameOfFinishedPlayer + " (TÚ)";
            }

            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.LogFormat("choco con algo: {0}", collision.name);
        if (Checkpoints.Contains(collision.gameObject))
        {
            int indexOfTrigger = Checkpoints.IndexOf(collision.gameObject);
            NumeroCheckpointActual = indexOfTrigger;
            //Checkpoints[indexOfTrigger].SetActive(false);
            if (collision.name.Contains("FinishTrigger"))
            {
                Debug.Log("si entro al script que lo termina");
                GameFinished();
            }
        }
    }
    void GameFinished()
    {
        GetComponent<CarMovement>().enabled = false;

        finishOrder += 1;
        string nickName = photonView.Owner.NickName;
        int viewID = photonView.ViewID;
        //event data
        object[] data = new object[] {nickName, finishOrder, viewID};

        RaiseEventOptions raiseEventOptions = new RaiseEventOptions() 
        {
            Receivers = ReceiverGroup.All,
            CachingOption = EventCaching.AddToRoomCache
        };

        //send options
        SendOptions sendOptions = new SendOptions
        {
            Reliability = false
        };
        PhotonNetwork.RaiseEvent((byte)RaiseEventsCode.WhoFinishedEventCode, data, raiseEventOptions, sendOptions);


    }
}
