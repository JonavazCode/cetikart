using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointsPerPJ : MonoBehaviour
{
    private LevelManager levelManager; //instancia de LevelManager
    public GameObject molina, coco, nino, ruben, sergio, ulyses, areli, susana;
    public List<GameObject> profesores;
    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>(); //encuentra el objeto LevelManager
        StartCoroutine(defaultCheckpoint());
        defaultCheckpoint();
        //agregarProfesoresList();
    }

    IEnumerator defaultCheckpoint()
    {
        yield return new WaitForSeconds(0.5f);
        molina = levelManager.checkPoints[0];
        coco = levelManager.checkPoints[0];
        nino = levelManager.checkPoints[0];
        ruben = levelManager.checkPoints[0];
        sergio = levelManager.checkPoints[0];
        ulyses = levelManager.checkPoints[0];
        areli = levelManager.checkPoints[0];
        susana = levelManager.checkPoints[0];
    }
    /*
    private void agregarProfesoresList()
    {
        profesores.Add(molina);
        profesores.Add(coco);
        profesores.Add(nino);
        profesores.Add(ruben);
        profesores.Add(sergio);
        profesores.Add(ulyses);
        profesores.Add(areli);
        profesores.Add(susana);

    }
    */

}