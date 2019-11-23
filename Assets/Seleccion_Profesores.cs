using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput; //Esta es una libreria necesaria para poder controlar y usar los botones o areas Axis touch dentro de la pantalla
using UnityEngine.SceneManagement; //Con esta libreria es posiible controlar el cambio entre scenas dentro del juego

public class Seleccion_Profesores : MonoBehaviour
{
    [SerializeField]
    public List<GameObject> profesores;
    void Update()
    {
        if (CrossPlatformInputManager.GetButton("profesor_molina"))//Esta condicion hace que cuando se presiona el boton del profesor seleccionado se envie al usuario a la seleccion del mapa con el personaje seleccionado
        {
            GameObject profesor = instanciarProfesor(0);
            DontDestroyOnLoad(profesor);//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 
            SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que la escena seleccionada se cargue
           

        }

        if (CrossPlatformInputManager.GetButton("profesor_coco"))//Esta condicion hace que cuando se presiona el boton del profesor seleccionado se envie al usuario a la seleccion del mapa con el personaje seleccionado
        {

            GameObject profesor = instanciarProfesor(0);
            DontDestroyOnLoad(profesor);//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 
            SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 
        }

        if (CrossPlatformInputManager.GetButton("profesor_sergio"))//Esta condicion hace que cuando se presiona el boton del profesor seleccionado se envie al usuario a la seleccion del mapa con el personaje seleccionado
        {

            GameObject profesor = instanciarProfesor(0);
            DontDestroyOnLoad(profesor);//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 
            SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 

        }

        if (CrossPlatformInputManager.GetButton("profesor_areli"))//Esta condicion hace que cuando se presiona el boton del profesor seleccionado se envie al usuario a la seleccion del mapa con el personaje seleccionado
        {

            GameObject profesor = instanciarProfesor(0);
            DontDestroyOnLoad(profesor);//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 
            SceneManager.LoadScene("Seleccion_Mapa"); ;//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 

        }

        if (CrossPlatformInputManager.GetButton("profesor_susana"))//Esta condicion hace que cuando se presiona el boton del profesor seleccionado se envie al usuario a la seleccion del mapa con el personaje seleccionado
        {
            GameObject profesor = instanciarProfesor(0);
            DontDestroyOnLoad(profesor);//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 
            SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 

        }

        if (CrossPlatformInputManager.GetButton("profesor_ulyses"))//Esta condicion hace que cuando se presiona el boton del profesor seleccionado se envie al usuario a la seleccion del mapa con el personaje seleccionado
        {
            GameObject profesor = instanciarProfesor(0);
            DontDestroyOnLoad(profesor);//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 
            SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 

        }

        if (CrossPlatformInputManager.GetButton("profesor_niño"))//Esta condicion hace que cuando se presiona el boton del profesor seleccionado se envie al usuario a la seleccion del mapa con el personaje seleccionado
        {

            GameObject profesor = instanciarProfesor(0);
            DontDestroyOnLoad(profesor);//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 
            SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 


        }

        if (CrossPlatformInputManager.GetButton("profesor_ruben"))//Esta condicion hace que cuando se presiona el boton del profesor seleccionado se envie al usuario a la seleccion del mapa con el personaje seleccionado
        {
            GameObject profesor = instanciarProfesor(0);
            DontDestroyOnLoad(profesor);//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 
            SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 

        }
   
    }

    private GameObject instanciarProfesor(int index)
    {
        var instanciaP = Instantiate(profesores[index], new Vector2(-3, 6), Quaternion.identity);
        instanciaP.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        return instanciaP;
    }
}
