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

        if (other.name.Contains("molina"))
        {
            levelManager.RespawnPlayer(other.name, cpp.molina);
        }
        else if (other.name.Contains("coco"))
        {
            levelManager.RespawnPlayer(other.name, cpp.coco);
        }
        else if (other.name.Contains("nino"))
        {
            levelManager.RespawnPlayer(other.name, cpp.nino);
        }
        else if (other.name.Contains("agentek"))
        {
            levelManager.RespawnPlayer(other.name, cpp.agentek);
        }
        else if (other.name.Contains("sergio"))
        {
            levelManager.RespawnPlayer(other.name, cpp.sergio);
        }
        else if (other.name.Contains("areli"))
        {
            levelManager.RespawnPlayer(other.name, cpp.areli);
        }
        else if (other.name.Contains("gussa"))
        {
            levelManager.RespawnPlayer(other.name, cpp.gussa);
        }
        else if (other.name.Contains("ulyses"))
        {
            levelManager.RespawnPlayer(other.name, cpp.ulyses);
        }

    }
}
