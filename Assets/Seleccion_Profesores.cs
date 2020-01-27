using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput; //Esta es una libreria necesaria para poder controlar y usar los botones o areas Axis touch dentro de la pantalla
using UnityEngine.SceneManagement; //Con esta libreria es posiible controlar el cambio entre scenas dentro del juego

public class Seleccion_Profesores : MonoBehaviour
{
    [SerializeField]
   

    public void SelecMolina()
    {
        SelecProf.PersonajeSeleccionado = 0;
        SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que la escena seleccionada se cargue
    }
    public void SelecIsmael()
    {
        SelecProf.PersonajeSeleccionado = 1;
        SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que la escena seleccionada se cargue
    }
    public void SelecRene()
    {
        SelecProf.PersonajeSeleccionado = 3;
        SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que la escena seleccionada se cargue
    }
    public void SelecAreli()
    {
        SelecProf.PersonajeSeleccionado = 2;
        SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que la escena seleccionada se cargue

    }
    public void SelecSusana()
    {
        SelecProf.PersonajeSeleccionado = 7;
        SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que la escena seleccionada se cargue

    }
    public void SelecNino()
    {
        SelecProf.PersonajeSeleccionado = 5;
        SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que la escena seleccionada se cargue

    }
    public void SelecSergio()
    {
        SelecProf.PersonajeSeleccionado = 4;
        SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que la escena seleccionada se cargue

    }
    public void SelecUlyses()
    {
        SelecProf.PersonajeSeleccionado = 6;
        SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que la escena seleccionada se cargue

    }
    public void SelecBack()
    {
        SceneManager.LoadScene("Seleccion_Dificultad");//Esta funcion hace que la escena seleccionada se cargue
    }
    public void SelecCustom()
    {
        SceneManager.LoadScene("Custom");//Esta funcion hace que la escena seleccionada se cargue
    }


}
