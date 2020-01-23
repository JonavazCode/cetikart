using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput; //Esta es una libreria necesaria para poder controlar y usar los botones touch o areas Axis touch dentro de la pantalla
using UnityEngine.SceneManagement; //Con esta libreria es posiible controlar el cambio entre scenas dentro del juego
using UnityEngine.UI;

public class Seleccion_Dificultad : MonoBehaviour
{

    public void SeleccionFacil()
    {
        SceneManager.LoadScene("Seleccion_Personaje");
    }
    public void SeleccionMedio()
    {
        SceneManager.LoadScene("Seleccion_Personaje");
    }
    public void SeleccionDificil()
    {
        SceneManager.LoadScene("Seleccion_Personaje");
    }
    public void SeleccionBack()
    {
        SceneManager.LoadScene("Menu_Principal");
    }
}
