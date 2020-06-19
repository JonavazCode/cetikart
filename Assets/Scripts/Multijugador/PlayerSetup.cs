using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerSetup : MonoBehaviourPunCallbacks
{
    public string id;
    private Posiciones_Multijugador PosicionesMultijugador;
    private ActivarPoderEspecial PoderEspecial;
    public TacometroMultijugador Tacometro;
    public TextMeshProUGUI PlayerNameText;

    // Start is called before the first frame update
    void Start()
    {
        if (photonView.IsMine)
        {
            //cargar los datos del tipo de poder y exactamente quien es el objeto del server
            try
            {
                PosicionesMultijugador = FindObjectOfType<Posiciones_Multijugador>();
                PoderEspecial = FindObjectOfType<ActivarPoderEspecial>();
                gameObject.name = photonView.ViewID.ToString();
                Tacometro = FindObjectOfType<TacometroMultijugador>();
                Tacometro._rigidbody = gameObject.GetComponent<Rigidbody2D>();
                GetComponent<CarMovement>().enabled = true;
                GetComponent<LapController>().enabled = true;
                PosicionesMultijugador.jugador = gameObject;
                PoderEspecial.Jugador = gameObject;
            }
            catch {
                Debug.Log("No se encuentran cosas");
            }
        }
        else
        {
            gameObject.name = photonView.ViewID.ToString();
            GetComponent<CarMovement>().enabled = false;
            GetComponent<LapController>().enabled = true;
        }
        SetPlayerUI();
    }

    private void SetPlayerUI()
    {
        if (PlayerNameText != null)
        {
            PlayerNameText.text = photonView.Owner.NickName;
            if (photonView.IsMine)
            {
                PlayerNameText.gameObject.SetActive(false);
            }
        }

    }

    [PunRPC]
    public void salirdeljuego()
    {
        PhotonNetwork.LeaveRoom();
    }

    public override void OnLeftRoom()
    {
        SceneManager.LoadScene("LobbyScene");
        Destroy(gameObject);
    }
}
