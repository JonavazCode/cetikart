using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerItemInteract : MonoBehaviourPun, IInteraction
{
    [SerializeField] private bool inmune = false;
    [SerializeField] private int cargas;
    [SerializeField] private float velocidad;

    #region Métodos PunRPC
    [PunRPC]
    public void moverPj(Vector3 pos)
    {
        gameObject.transform.position = pos;
    }

    [PunRPC]
    public void CambiarInmune()
    {
        inmune = !inmune;
    }

    [PunRPC]
    public void AumentarCargas()
    {
        Debug.Log("Aumentar cargas");
        if(!LimiteDeCargas())
            cargas++;
        Debug.Log("Cargas: " + cargas);
    }


    #endregion

    #region Métodos de la clase

    private bool LimiteDeCargas()
    {
        return cargas >= 3 ? true : false;
    }
    #endregion

}
