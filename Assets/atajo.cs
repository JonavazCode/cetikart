using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atajo : MonoBehaviour
{
    public LevelManager levelManager; //instancia de LevelManager
    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>(); //encuentra el objeto LevelManager
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Profesor Molina_Interfaz" || other.name == "Profesor_Coco_Interfaz" || other.name == "Profesor_Niño_Interfaz" || other.name == "Profesor_Ruben_Interfaz" || other.name == "Profesor_Sergio_Interfaz" || other.name == "Profesora_Areli_Interfaz" || other.name == "Profesora_Susana_Interfaz" || other.name == "Profesor_Ulyses_Interfaz")
        {
            //levelManager.Atajo();
        }
        Destroy(gameObject);
        

    }
}
