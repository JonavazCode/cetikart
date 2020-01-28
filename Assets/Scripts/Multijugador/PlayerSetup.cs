using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class PlayerSetup : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        if (photonView.IsMine)
        {
            GetComponent<CarMovement>().enabled = true;
        }
        else
        {
            GetComponent<CarMovement>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
