using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivarPoderEspecial : MonoBehaviourPun
{
    public string NombreJugador;
    public string TipoPoder;
    public GameObject Jugador;
    Button boton; 
    private void Start()
    {
        boton = gameObject.GetComponent<Button>();
        boton.interactable = false;
    }

    public void OnClickBotonPoderEspecial()
    {
        QuitarCargas();
        InteractableState();
        Poder();
    }

    public void Poder()
    {
        Jugador.GetComponent<PoderEspecial>().Poderes(Jugador.GetComponent<PlayerSetup>().id);
    }
    public void QuitarCargas()
    {
        Jugador.GetComponent<PhotonView>().RPC("QuitarCargas", RpcTarget.All);
    }
    public void InteractableState()
    {
        boton.interactable = !boton.interactable;
    }

    public void PonerDatos(string nj, string tp)
    {
        NombreJugador = nj;
        TipoPoder = tp;
    }
}
