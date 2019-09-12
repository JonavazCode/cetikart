using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public LevelManager levelManager; //instancia de LevelManager

    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>(); //encuentra el objeto LevelManager

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Profesor Molina_Interfaz" || other.name == "Profesor_Coco_Interfaz" || other.name == "Profesor_Niño_Interfaz" || other.name == "Profesor_Ruben_Interfaz" || other.name == "Profesor_Sergio_Interfaz" || other.name == "Profesora_Areli_Interfaz" || other.name == "Profesora_Susana_Interfaz" || other.name == "Profesor_Ulyses_Interfaz")
        {
            Debug.Log("Cambiando checkpoint");
            levelManager.currentCheckPoint = gameObject;    //actualiza el checkpoint actual
            if (!levelManager.checkPoints.Contains(gameObject)) //si  la lista no contiene a este gameobject
            {
                Debug.Log("agregado");
                levelManager.checkPoints.Add(gameObject); //agregalo a la lista
            }
        }
    }
}

