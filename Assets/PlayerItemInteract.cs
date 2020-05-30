using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class PlayerItemInteract : MonoBehaviourPun, IInteraction
{
    [SerializeField] public bool inmune = false;
    [SerializeField] private int cargas;
    [SerializeField] private float velocidad;
    [SerializeField] public int posicion;
    [SerializeField] public int posicionAnterior = 0;
    public bool arrebasoAAlguien;

    #region MetodosUnity
    public void Update()
    {
        if (posicion == posicionAnterior)
            arrebasoAAlguien = false;
        posicion = gameObject.PositionInCareer();
        si_rebasa();
        posicion = gameObject.PositionInCareer();
        posicionAnterior = posicion;
    }
    #endregion
    #region Métodos PunRPC
    [PunRPC]
    public void moverPj(Vector3 pos)
    {
        gameObject.transform.position = pos;
    }

    [PunRPC]
    public void CambiarInmune(bool estado)
    {
        inmune = estado;
    }
    [PunRPC]
    public void QuitarCargas()
    {
        cargas = 0;
    }
    [PunRPC]
    public void AumentarCargas()
    {
        //Debug.Log("Aumentar cargas");
        if (!LimiteDeCargas())
        {
            cargas++;
            if(cargas == 3 && photonView.IsMine)
            {
                var boton = GameObject.Find("BotonPoderEspecial");
                boton.GetComponent<ActivarPoderEspecial>().InteractableState();
            }
        }     
    }

    [PunRPC]
    public void AumentarEscala(float escala)
    {
        gameObject.transform.localScale = new Vector3((gameObject.transform.localScale.x * escala), (gameObject.transform.localScale.y * escala), (gameObject.transform.localScale.z * escala));
    }
    #endregion

    #region Métodos de la clase

    private bool LimiteDeCargas()
    {
        return cargas >= 3 ? true : false;
    }

    void si_rebasa()
    {
        if (ComprobarPosicionAnterior())
        {
            Debug.Log("Se entró");
            arrebasoAAlguien = true;
            gameObject.GetComponent<PhotonView>().RPC("AumentarCargas", RpcTarget.All);
        }
    }
    public bool ComprobarPosicionAnterior()
    {
        bool resultado = (posicionAnterior != 0) && (posicionAnterior > posicion);
        return resultado;
    }
    #endregion

}
