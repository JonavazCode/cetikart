using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private LevelManager levelManager; //instancia de LevelManager
    private static string _carE = "_carE";
    private CheckpointsPerPJ cpp;
    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>(); //encuentra el objeto LevelManager
        cpp = FindObjectOfType<CheckpointsPerPJ>();

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        /* if (other.name == "Profesor Molina_Interfaz" || other.name == "Profesor_Coco_Interfaz" || other.name == "Profesor_Niño_Interfaz" || other.name == "Profesor_Ruben_Interfaz" || other.name == "Profesor_Sergio_Interfaz" || other.name == "Profesora_Areli_Interfaz" || other.name == "Profesora_Susana_Interfaz" || other.name == "Profesor_Ulyses_Interfaz")
         {
             Debug.Log("Cambiando checkpoint");
             levelManager.currentCheckPoint = gameObject;    //actualiza el checkpoint actual
             if (!levelManager.checkPoints.Contains(gameObject)) //si  la lista no contiene a este gameobject
             {
                 Debug.Log("agregado");
                 levelManager.checkPoints.Add(gameObject); //agregalo a la lista
             }
         }*/

        if (other.name == "molina_car" || other.name == ("molina" + _carE))
        {
            cpp.molina = gameObject;
        }
        else if (other.name == "coco_car" || other.name == ("coco" + _carE))
        {
            cpp.coco = gameObject;
        }
        else if (other.name == "nino_car" || other.name == ("nino" + _carE))
        {
            cpp.nino = gameObject;
        }
        else if (other.name == "agentek_car" || other.name == ("agentek" + _carE))
        {
            cpp.ruben = gameObject;
        }
        else if (other.name == "sergio_car" || other.name == ("sergio" + _carE))
        {
            cpp.sergio = gameObject;
        }
        else if (other.name == "areli_car" || other.name == ("areli" + _carE))
        {
            cpp.areli = gameObject;
        }
        else if (other.name == "gussa_car" || other.name == ("gussa" + _carE))
        {
            cpp.susana = gameObject;
        }
        else if (other.name == "ulyses_car" || other.name == ("ulyses" + _carE))
        {
            cpp.ulyses = gameObject;
        }
    }
}
    


