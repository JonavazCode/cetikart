using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput; //Esta es una libreria necesaria para poder controlar y usar los botones touch o areas Axis touch dentro de la pantalla
using UnityEngine.SceneManagement; //Con esta libreria es posiible controlar el cambio entre scenas dentro del juego

public class Selector_de_mapa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CrossPlatformInputManager.GetButton("Colomos"))//Esta condicion hace que cuando se presiona el boton de un mapa, mande al usuario al mapa seleccionado
        {

            SceneManager.LoadScene("Colomos");//Esta funcion hace que la escena seleccionada se cargue


        }

        if (CrossPlatformInputManager.GetButton("Gimnasio"))//Esta condicion hace que cuando se presiona el boton de un mapa, mande al usuario al mapa seleccionado
        {

            SceneManager.LoadScene("Gimnasio");//Esta funcion hace que la escena seleccionada se cargue


        }

        if (CrossPlatformInputManager.GetButton("Baños"))//Esta condicion hace que cuando se presiona el boton de un mapa, mande al usuario al mapa seleccionado
        {

            SceneManager.LoadScene("Baños");//Esta funcion hace que la escena seleccionada se cargue


        }

        if (CrossPlatformInputManager.GetButton("Edificio L"))//Esta condicion hace que cuando se presiona el boton de un mapa, mande al usuario al mapa seleccionado
        {

            SceneManager.LoadScene("Edificio L");//Esta funcion hace que la escena seleccionada se cargue


        }

        if (CrossPlatformInputManager.GetButton("Edificio F"))//Esta condicion hace que cuando se presiona el boton de un mapa, mande al usuario al mapa seleccionado
        {

            SceneManager.LoadScene("Edificio F");//Esta funcion hace que la escena seleccionada se cargue


        }

        if (CrossPlatformInputManager.GetButton("Edificio B"))//Esta condicion hace que cuando se presiona el boton de un mapa, mande al usuario al mapa seleccionado
        {

            SceneManager.LoadScene("Edificio B");//Esta funcion hace que la escena seleccionada se cargue


        }

        if (CrossPlatformInputManager.GetButton("Estacionamiento"))//Esta condicion hace que cuando se presiona el boton de un mapa, mande al usuario al mapa seleccionado
        {

            SceneManager.LoadScene("Estacionamiento");//Esta funcion hace que la escena seleccionada se cargue


        }

        if (CrossPlatformInputManager.GetButton("Plantel"))//Esta condicion hace que cuando se presiona el boton de un mapa, mande al usuario al mapa seleccionado
        {

            SceneManager.LoadScene("Mapa_Pruebas");//Esta funcion hace que la escena seleccionada se cargue


        }
        
    }
}
