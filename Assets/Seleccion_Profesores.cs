using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput; //Esta es una libreria necesaria para poder controlar y usar los botones o areas Axis touch dentro de la pantalla
using UnityEngine.SceneManagement; //Con esta libreria es posiible controlar el cambio entre scenas dentro del juego

public class Seleccion_Profesores : MonoBehaviour
{
    GameObject profesor, Profesora_Susana, Profesora_Areli, Profesor_Coco, Profesor_Niño, Profesor_Ulyses, Profesor_Ruben, Profesor_Molina, Profesor_Sergio; //Estas variables van a utilizarse para asociarse con los sprites dentro del proyecto
    
    void Awake()//Esta funcion hace que todo lo que haya dentro de ella se ejecuten antes de que se inicie el juego y solo se mandan llamar una vez en todo su ciclo de escena
    {
        Profesora_Susana = GameObject.FindWithTag("Profesora_Susana"); //Asociamos las variables de "GameObject" con los sprites de cada uno de los profesores dentro del proyecto
        Profesora_Areli = GameObject.FindWithTag("Profesora_Areli");
        Profesor_Coco = GameObject.FindWithTag("Profesor_Coco");
        Profesor_Niño = GameObject.FindWithTag("Prfesor_Niño");
        Profesor_Ulyses = GameObject.FindWithTag("Profesor_Ulyses");
        Profesor_Ruben = GameObject.FindWithTag("Profesor_Ruben");
        Profesor_Molina = GameObject.FindWithTag("Profesor_Molina");
        Profesor_Sergio = GameObject.FindWithTag("Profesor_Sergio");
        
    }
    void Start()
    {
    
        
    }

   
    void Update()
    {
        if (CrossPlatformInputManager.GetButton("profesor_molina"))//Esta condicion hace que cuando se presiona el boton del profesor seleccionado se envie al usuario a la seleccion del mapa con el personaje seleccionado
        {

            SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que la escena seleccionada se cargue
            DontDestroyOnLoad(Profesor_Molina);//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 

        }

        if (CrossPlatformInputManager.GetButton("profesor_coco"))//Esta condicion hace que cuando se presiona el boton del profesor seleccionado se envie al usuario a la seleccion del mapa con el personaje seleccionado
        {

            SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que la escena seleccionada se cargue
            DontDestroyOnLoad(Profesor_Coco);//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 
        }

        if (CrossPlatformInputManager.GetButton("profesor_sergio"))//Esta condicion hace que cuando se presiona el boton del profesor seleccionado se envie al usuario a la seleccion del mapa con el personaje seleccionado
        {

            SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que la escena seleccionada se cargue
            DontDestroyOnLoad(Profesor_Sergio);//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 

        }

        if (CrossPlatformInputManager.GetButton("profesor_areli"))//Esta condicion hace que cuando se presiona el boton del profesor seleccionado se envie al usuario a la seleccion del mapa con el personaje seleccionado
        {

            SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que la escena seleccionada se cargue
            DontDestroyOnLoad(Profesora_Areli);//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 

        }

        if (CrossPlatformInputManager.GetButton("profesor_susana"))//Esta condicion hace que cuando se presiona el boton del profesor seleccionado se envie al usuario a la seleccion del mapa con el personaje seleccionado
        {

            SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que la escena seleccionada se cargue
            DontDestroyOnLoad(Profesora_Susana);//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 

        }

        if (CrossPlatformInputManager.GetButton("profesor_ulyses"))//Esta condicion hace que cuando se presiona el boton del profesor seleccionado se envie al usuario a la seleccion del mapa con el personaje seleccionado
        {

            SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que la escena seleccionada se cargue
            DontDestroyOnLoad(Profesor_Ulyses);//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 

        }

        if (CrossPlatformInputManager.GetButton("profesor_niño"))//Esta condicion hace que cuando se presiona el boton del profesor seleccionado se envie al usuario a la seleccion del mapa con el personaje seleccionado
        {

            SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que la escena seleccionada se cargue
            DontDestroyOnLoad(Profesor_Niño);//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 


        }

        if (CrossPlatformInputManager.GetButton("profesor_ruben"))//Esta condicion hace que cuando se presiona el boton del profesor seleccionado se envie al usuario a la seleccion del mapa con el personaje seleccionado
        {

            SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que la escena seleccionada se cargue
            DontDestroyOnLoad(Profesor_Ruben);//Esta funcion hace que cundo cambie la escena el sprite del profesor seleccionado no se destruya y vaya a la siguiente escena con todos sus componentes 

        }
        
    }
}
