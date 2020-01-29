using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
public class TimeCountDownManager : MonoBehaviourPun
{
    private Text TimeUIText;
    private float timetoStartRace = 3.0f;
    private void Awake()
    {
        TimeUIText = RacingModeGameManager.instance.timeUIText;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            if (timetoStartRace >= 0.0f)
            {
                timetoStartRace -= Time.deltaTime;
                photonView.RPC("SetTime", RpcTarget.AllBuffered, timetoStartRace);
            }
            else if (timetoStartRace < 0.0f)
            {
                photonView.RPC("StartTheRace", RpcTarget.AllBuffered);
            }
        }       
    }

    [PunRPC]
    public void SetTime(float time)
    {
        if (time > 0.0f)
        {
            TimeUIText.text = time.ToString("F1");
        }
        else
        {
            TimeUIText.text = "";
        }
    }
    [PunRPC]
    public void StartTheRace()
    {
        GetComponent<CarMovement>().controlsEnabled = true;
        this.enabled = false;
    }
}
