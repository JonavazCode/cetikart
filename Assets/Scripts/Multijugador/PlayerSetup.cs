using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
public class PlayerSetup : MonoBehaviourPunCallbacks
{
    private Posiciones_Multijugador PosicionesMultijugador;
    public TacometroMultijugador Tacometro;
    public TextMeshProUGUI PlayerNameText;
    // Start is called before the first frame update
    void Start()
    {
        if (photonView.IsMine)
        {
            PosicionesMultijugador = FindObjectOfType<Posiciones_Multijugador>();
            gameObject.name = photonView.ViewID.ToString();
            Tacometro = FindObjectOfType<TacometroMultijugador>();
            Tacometro._rigidbody = gameObject.GetComponent<Rigidbody2D>();
            GetComponent<CarMovement>().enabled = true;
            GetComponent<LapController>().enabled = true;
            PosicionesMultijugador.jugador = gameObject;
            
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
}
