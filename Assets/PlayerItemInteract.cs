using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerItemInteract : MonoBehaviourPun
{
    [PunRPC]
    public void moverPj(Vector3 pos)
    {
        gameObject.transform.position = pos;
    }


}
