using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput; //Esta es una libreria necesaria para poder controlar y usar los botones touch o areas Axis touch dentro de la pantalla
using UnityEngine.SceneManagement; //Con esta libreria es posiible controlar el cambio entre scenas dentro del juego

public class Finalizar_Creacion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CrossPlatformInputManager.GetButton("Finalizar"))//Esta condicion hace que cuando se presiona el boton de "Un jugador" se envie al usuario a la seleccion de personaje
        {

            SceneManager.LoadScene("Menu_Principal");//Esta funcion hace que la escena seleccionada se cargue


        }
        
    }
}
