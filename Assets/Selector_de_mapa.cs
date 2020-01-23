using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput; //Esta es una libreria necesaria para poder controlar y usar los botones touch o areas Axis touch dentro de la pantalla
using UnityEngine.SceneManagement; //Con esta libreria es posiible controlar el cambio entre scenas dentro del juego

public class Selector_de_mapa : MonoBehaviour
{

    public void Colomos()
    {
        SceneManager.LoadScene("Colomos");//Esta funcion hace que la escena seleccionada se cargue
    }
    public void Gimnasio()
    {
        SceneManager.LoadScene("Gimnasio");//Esta funcion hace que la escena seleccionada se cargue
    }
    public void Edificio_L()
    {
        SceneManager.LoadScene("Edificio L");//Esta funcion hace que la escena seleccionada se cargue
    }
    public void Edificio_B()
    {
        SceneManager.LoadScene("Edificio B");//Esta funcion hace que la escena seleccionada se cargue
    }
    public void Edificio_F()
    {
        SceneManager.LoadScene("Edificio F");//Esta funcion hace que la escena seleccionada se cargue
    }
    public void Banos()
    {
        SceneManager.LoadScene("Baños");//Esta funcion hace que la escena seleccionada se cargue
    }
    public void Estacionamiento()
    {
        SceneManager.LoadScene("Estacionamiento");//Esta funcion hace que la escena seleccionada se cargue
    }
    public void Plantel()
    {
        SceneManager.LoadScene("Mapa_Pruebas");//Esta funcion hace que la escena seleccionada se cargue
    }
    public void Back()
    {
        SceneManager.LoadScene("Seleccion_Personaje");//Esta funcion hace que la escena seleccionada se cargue
    }

   
}
