using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput; //Esta es una libreria necesaria para poder controlar y usar los botones o areas Axis touch dentro de la pantalla

public class Poner_y_quitar_mute : MonoBehaviour
{
    public bool mute; //Esta variable es el parametro usando dentro de las animaciones para cambiar a la animacion de MUTE
    private Animator animacion_mute; // Esta variable es la que será usada para poder tomar la animacion dentro del proyecto
    AudioSource Cancion_Interfaz; //Es el nombre de la variable con la cual vamos a asociar la pista de audio del interfaz
    
    void Start()
    {
        animacion_mute = GetComponent<Animator>(); //Asociamos la variable con el componente que contiene el objeto del proyecto, en este caso la animacion 
        mute = false; //Cuando la variable "mute" este en true esta mostrara la animacion de que no hay sonido, de lo contrario sonara la pista, por esto se inicializa en "false"
        Cancion_Interfaz = GetComponent<AudioSource>(); //Asociamos la variable con el componente que contiene el objeto del proyecto, en este caso la pista de audio 
        animacion_mute.SetBool("mute", mute);
    }

    
    void Update()
    {
        //animacion_mute.SetBool("mute", mute); //En esta parte se toma el parametro dentro del Animator para validarlo con la variable dentro del script y comprovar el estado del booleando en este caso, el mute
        //if (CrossPlatformInputManager.GetButton("mute")) //Con esta condicion se dice que si el boton de "mute" se presiona, hace que la pista de audio se silencie y hace que el parametro de la animacion sea diferente cada que se presione 
        //{
        //    Cancion_Interfaz.mute = !Cancion_Interfaz.mute;
        //    mute = !mute;
        //}
        
    }

    public void BotonMutePresionado()
    {
        Cancion_Interfaz.mute = !Cancion_Interfaz.mute;
        mute = !mute;
        animacion_mute.SetBool("mute", mute);
    }
}
