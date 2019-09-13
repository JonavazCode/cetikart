using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput; //Esta es una libreria necesaria para poder controlar y usar los botones touch o areas Axis touch dentro de la pantalla
using UnityEngine.SceneManagement; //Con esta libreria es posiible controlar el cambio entre scenas dentro del juego


public class Botones_de_Menu_Principal : MonoBehaviour
{
    
    void Update()
    {

        if (CrossPlatformInputManager.GetButton("un_jugador"))//Esta condicion hace que cuando se presiona el boton de "Un jugador" se envie al usuario a la seleccion de personaje
        {

            SceneManager.LoadScene("Seleccion_Dificultad");//Esta funcion hace que la escena seleccionada se cargue
           

        }

        if (Inicio_Menu_Principal.flagMultijugador)
        {
            GameObject disableMultiplayerButton = GameObject.Find("botonMultijugador");
            disableMultiplayerButton.SetActive(false);
        }

        if (CrossPlatformInputManager.GetButton("multijugador") && !Inicio_Menu_Principal.flagMultijugador)//Esta condicion hace que cuando se presiona el boton de "Multijugador" se envie al usuario al loggeo del multijugador
        {

            Debug.Log(Inicio_Menu_Principal.flagMultijugador);
            SceneManager.LoadScene("Multijugador");//Esta funcion hace que la escena seleccionada se cargue
            Debug.Log("va al multijugador");
            Inicio_Menu_Principal.flagMultijugador = true;
            Debug.Log(Inicio_Menu_Principal.flagMultijugador);

        }

        if (CrossPlatformInputManager.GetButton("crear_jugador"))//Esta condicion hace que cuando se presiona el boton de "Crear Player" se envie al usuario a la creacion de su personaje
        {
            SceneManager.LoadScene("Crear_Personaje");//Esta funcion hace que la escena seleccionada se cargue
            
        }

        if (CrossPlatformInputManager.GetButton("salir"))//Esta condicion hace que cuando se presione el boton de "Salir" la aplicacion se cierre
        {
            
            Application.Quit();

        }
        
    }
}
