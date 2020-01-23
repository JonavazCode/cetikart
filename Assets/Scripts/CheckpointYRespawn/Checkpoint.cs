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
            cpp.agentek = gameObject;
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
            cpp.gussa = gameObject;
        }
        else if (other.name == "ulyses_car" || other.name == ("ulyses" + _carE))
        {
            cpp.ulyses = gameObject;
        }
    }
}
    


