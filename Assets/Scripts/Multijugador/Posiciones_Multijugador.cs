using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Posiciones_Multijugador : MonoBehaviour
{
    public GameObject jugador;
    public Sprite posicion_1;
    public Sprite posicion_2;
    public Sprite posicion_3;
    public Sprite posicion_4;
    public Sprite posicion_5;
    public Sprite posicion_6;
    public Sprite posicion_7;
    public Sprite posicion_8;
    void Update()
    {
        if (RacingModeGameManager.instance.PosicionCarrera[1] == jugador.name)
        {
            this.gameObject.GetComponent<Image>().sprite = posicion_1;
        }
        else if (RacingModeGameManager.instance.PosicionCarrera[2] == jugador.name)
        {
            this.gameObject.GetComponent<Image>().sprite = posicion_2;
        }
        else if(RacingModeGameManager.instance.PosicionCarrera[3] == jugador.name)
        {
            this.gameObject.GetComponent<Image>().sprite = posicion_3;
        }
        else if(RacingModeGameManager.instance.PosicionCarrera[4] == jugador.name)
        {
            this.gameObject.GetComponent<Image>().sprite = posicion_4;
        }
        else if(RacingModeGameManager.instance.PosicionCarrera[5] == jugador.name)
        {
            this.gameObject.GetComponent<Image>().sprite = posicion_5;
        }
        else if(RacingModeGameManager.instance.PosicionCarrera[6] == jugador.name)
        {
            this.gameObject.GetComponent<Image>().sprite = posicion_6;
        }
        else if(RacingModeGameManager.instance.PosicionCarrera[7] == jugador.name)
        {
            this.gameObject.GetComponent<Image>().sprite = posicion_7;
        }
        else if(RacingModeGameManager.instance.PosicionCarrera[8] == jugador.name)
        {
            this.gameObject.GetComponent<Image>().sprite = posicion_8;
        }
    }
}
