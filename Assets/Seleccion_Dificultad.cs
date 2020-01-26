using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput; //Esta es una libreria necesaria para poder controlar y usar los botones touch o areas Axis touch dentro de la pantalla
using UnityEngine.SceneManagement; //Con esta libreria es posiible controlar el cambio entre scenas dentro del juego
using UnityEngine.UI;

public class Seleccion_Dificultad : MonoBehaviour
{
    public Dificultad dificultad;
    public void Start()
    {
        dificultad = FindObjectOfType<Dificultad>();
    }
    public void SeleccionFacil()
    {
        dificultad.nivel_dificultad = 1;
        SceneManager.LoadScene("Seleccion_Personaje");
    }
    public void SeleccionMedio()
    {
        dificultad.nivel_dificultad = 2;
        SceneManager.LoadScene("Seleccion_Personaje");
    }
    public void SeleccionDificil()
    {
        dificultad.nivel_dificultad = 3;
        SceneManager.LoadScene("Seleccion_Personaje");
    }
    public void SeleccionBack()
    {
        SceneManager.LoadScene("Menu_Principal");
    }
}
