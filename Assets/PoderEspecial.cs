using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class PoderEspecial : MonoBehaviourPun
{
    [SerializeField] public bool PoderEspecialActivo;
    public void Poderes(string TipoPoder)
    {
        switch (TipoPoder)
        {
            case "molina": 
                PoderMolina();
                break;
            case "sergio":
                PoderSergio();
                break;
            
        }
    }



    public void PoderMolina()
    {
        Debug.Log("Poder uno");
        gameObject.GetComponent<PhotonView>().RPC("ActualizarVelocidad", RpcTarget.All, 100f);
        StartCoroutine(TiempoEspera(5f));
        //List<GameObject> Afectados = new List<GameObject>();
        //var pii = gameObject.GetComponent<PlayerItemInteract>();
        //while (PoderEspecialActivo)
        //{   
        //    //comprobar si adelantó a alguien
        //    if (pii.ComprobarPosicionAnterior())
        //    {
        //        //si no es el primer lugar
        //        if (pii.posicion != 1)
        //        {
        //            var Afectado = GameObject.Find(RacingModeGameManager.instance.PosicionCarrera[pii.posicion + 1]);
        //            //si el afectado no está en la lista lo agrega, si ya está no hace nada
        //            if (!Afectados.Contains(Afectado))
        //                Afectados.Add(Afectado);
        //            //le reduce la velocidad
        //            Afectado.GetComponent<PhotonView>().RPC("ActualizarVelocidad", RpcTarget.All, -200f);
        //        }
        //    }
        //}
        ////cuando ya no está en el poder especial, busca a todos los enemigos afectados y les devuelve su velocidad
        //foreach (GameObject afectado in Afectados)
        //{
        //    afectado.GetComponent<PhotonView>().RPC("ActualizarVelocidad", RpcTarget.All, 200f);
        //}
        //Devuelve la velocidad a este objeto
        gameObject.GetComponent<PhotonView>().RPC("ActualizarVelocidad", RpcTarget.All, -100f);
    }

    public void PoderSergio()
    {
        Debug.Log("Poder dos");
        gameObject.GetComponent<PhotonView>().RPC("ActualizarVelocidad", RpcTarget.All, 300f);
 
        gameObject.GetComponent<PhotonView>().RPC("ActualizarVelocidad", RpcTarget.All, -300f);
    }


    public IEnumerator TiempoEspera(float segundos)
    {
        PoderEspecialActivo = true;
        yield return new WaitForSeconds(segundos);
        PoderEspecialActivo = false;
    }
}
