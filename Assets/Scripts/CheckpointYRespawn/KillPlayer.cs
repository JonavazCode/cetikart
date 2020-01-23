using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    private LevelManager levelManager; //instancia de LevelManager
    private CheckpointsPerPJ cpp;

    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>(); //encuentra el objeto LevelManager
        cpp = FindObjectOfType<CheckpointsPerPJ>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        /*if (other.tag == "Player" || other.tag == "Enemy")
        {
            levelManager.RespawnPlayer(other.name, cpp);  
        }
        */

        if (other.name == "molina_car" || other.name == "MolinaE")
        {
            levelManager.RespawnPlayer(other.name, cpp.molina);
        }
        else if (other.name == "coco_car" || other.name == "CocoE")
        {
            levelManager.RespawnPlayer(other.name, cpp.coco);
        }
        else if (other.name == "niño_car" || other.name == "NinoE")
        {
            levelManager.RespawnPlayer(other.name, cpp.nino);
        }
        else if (other.name == "ruben_car" || other.name == "RubenE")
        {
            levelManager.RespawnPlayer(other.name, cpp.agentek);
        }
        else if (other.name == "sergio_car" || other.name == "SergioE")
        {
            levelManager.RespawnPlayer(other.name, cpp.sergio);
        }
        else if (other.name == "areli_car" || other.name == "AreliE")
        {
            levelManager.RespawnPlayer(other.name, cpp.areli);
        }
        else if (other.name == "susana_car" || other.name == "SusanaE")
        {
            levelManager.RespawnPlayer(other.name, cpp.gussa);
        }
        else if (other.name == "ulyses_car" || other.name == "UlysesE")
        {
            levelManager.RespawnPlayer(other.name, cpp.ulyses);
        }

    }
}
