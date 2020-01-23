using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput; //Esta es una libreria necesaria para poder controlar y usar los botones o areas Axis touch dentro de la pantalla
using UnityEngine.SceneManagement; //Con esta libreria es posiible controlar el cambio entre scenas dentro del juego

public class Seleccion_Profesores : MonoBehaviour
{
    [SerializeField]
    public List<GameObject> profesores;
    public GameObject Profesor_Ismael;
    public GameObject Profesor_Molina;
    public GameObject Profesora_Susana;
    public GameObject Profesora_Areli;
    public GameObject Profesor_Rene;
    public GameObject Profesor_Sergio;
    public GameObject Profesor_Nino;
    public GameObject Profesor_Ulyses;

    public void SelecMolina()
    {
        DontDestroyOnLoad(Profesor_Molina);//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 
        SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que la escena seleccionada se cargue
    }
    public void SelecIsmael()
    {
        DontDestroyOnLoad(Profesor_Ismael);//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 
        SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que la escena seleccionada se cargue
    }
    public void SelecRene()
    {
        DontDestroyOnLoad(Profesor_Rene);//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 
        SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que la escena seleccionada se cargue
    }
    public void SelecAreli()
    {
        DontDestroyOnLoad(Profesora_Areli);//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 
        SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que la escena seleccionada se cargue

    }
    public void SelecSusana()
    {
        DontDestroyOnLoad(Profesora_Susana);//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 
        SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que la escena seleccionada se cargue

    }
    public void SelecNino()
    {
        DontDestroyOnLoad(Profesor_Nino);//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 
        SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que la escena seleccionada se cargue

    }
    public void SelecSergio()
    {
        DontDestroyOnLoad(Profesor_Sergio);//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 
        SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que la escena seleccionada se cargue

    }
    public void SelecUlyses()
    {
        DontDestroyOnLoad(Profesor_Ulyses);//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 
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
