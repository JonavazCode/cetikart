using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class PoderEspecial : MonoBehaviourPun
{
    public void Poderes(string TipoPoder)
    {
        switch (TipoPoder)
        {
            case "molina": 
                StartCoroutine(PoderMolina());
                break;
            case "sergio":
                StartCoroutine(PoderSergio());
                break;
            
        }
    }



    public IEnumerator PoderMolina()
    {
        Debug.Log("Poder uno");
        gameObject.GetComponent<PhotonView>().RPC("ActualizarVelocidad", RpcTarget.All, 1200f);
        yield return new WaitForSeconds(5);
        gameObject.GetComponent<PhotonView>().RPC("ActualizarVelocidad", RpcTarget.All, 1000f);
    }

    public IEnumerator PoderSergio()
    {
        Debug.Log("Poder dos");
        gameObject.GetComponent<PhotonView>().RPC("ActualizarVelocidad", RpcTarget.All, 1300f);
        yield return new WaitForSeconds(5);
        gameObject.GetComponent<PhotonView>().RPC("ActualizarVelocidad", RpcTarget.All, 1000f);
    }
}
