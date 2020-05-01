using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerItemInteract : MonoBehaviourPun
{
    int cargas;
    float velocidad;


    #region Métodos PunRPC
    [PunRPC]
    public void moverPj(Vector3 pos)
    {
        gameObject.transform.position = pos;
    }

    [PunRPC]
    public void ActualizarVelocidad(int velocidad)
    {
        gameObject.GetComponent<CarMovement>().SetSpeed(velocidad);
    }
    #endregion

    //#region Métodos de la clase

    //public void ObtenerVelocidad()
    //{ 
    //    velocidad = gameObject.GetComponent<CarMovement>().GetSpeed();
    //}

    //#endregion

}
