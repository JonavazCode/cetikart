using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointsPerPJ : MonoBehaviour
{
    #region flags

    private bool firstFlag = false; //bandera de espera para los items

    #endregion
    public bool carreraFinalizada = false;
    private LevelManager levelManager; //instancia de LevelManager
    public GameObject molina, coco, nino, ruben, sergio, ulyses, areli, susana;
    public List<GameObject> profesores;
    public string uno, dos, tres, cuatro, cinco, seis, siete, ocho;

    Transform molina_pos;
    Transform coco_pos;
    Transform nino_pos;
    Transform ruben_pos;
    Transform sergio_pos;
    Transform ulyses_pos;
    Transform areli_pos;
    Transform susana_pos;

    private float[] pos;

    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>(); //encuentra el objeto LevelManager
        StartCoroutine(defaultCheckpoint());
        defaultCheckpoint();
        //agregarProfesoresList();
        StartCoroutine(GenerarPosiciones());
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

    IEnumerator GenerarPosiciones()
    {
        while (true)
        {
            
            asociarPosiciones();
            pos = new float[2];
            pos[0] = molina_pos.position.x;
            pos[1] = coco_pos.position.x;
            //pos[n] = nombreprofesor.position.x;

            float molina = pos[0], coco = pos[1];
            MetodoBurbuja(molina, coco);
            imprimirPosiciones();
            yield return new WaitForSeconds(2);
        }

    
    }

    public void asociarPosiciones()
    {
        //si no los encuentra hacer que se guarde algun numero en x
        /// eso que lo haga mi yo del futuro


        molina_pos = GameObject.Find("molina_car").transform;
        coco_pos = GameObject.Find("coco_carE").transform;

    }

    private void MetodoBurbuja(float molina, float coco)
    {
        float t;
        for (int a = 1; a < pos.Length; a++)
            for (int b = pos.Length - 1; b >= a; b--)
            {
                if (pos[b - 1] > pos[b])
                {
                    t = pos[b - 1];
                    pos[b - 1] = pos[b];
                    pos[b] = t;
                }
            }
        /*
        for (int f = 6; f >= 0; f--)
        {
            
            if (molina == pos[f])
            {
                Debug.Log("molina es el lugar: " + f);
            }
            if (coco == pos[f])
            {
                Debug.Log("coco es el lugar: " + f);
            }
            

            //Debug.Log(pos[f] + "  ");
        }
        */

        if (molina == pos[0])
        {
            dos = molina_pos.name;
        }
        else if (molina == pos[1])
        {
            uno = molina_pos.name;
        }
        else if (molina == pos[2])
        {
            tres = molina_pos.name;
        }
        else if (molina == pos[3])
        {
            cuatro = molina_pos.name;
        }
        else if (molina == pos[4])
        {
            cinco = molina_pos.name;
        }
        else if (molina == pos[5])
        {
            seis = molina_pos.name;
        }
        else if (molina == pos[6])
        {
            siete = molina_pos.name;
        }
        else if (molina == pos[7])
        {
            ocho = molina_pos.name;
        }


        if (coco == pos[0])
        {
            dos = coco_pos.name;
        }
        else if (coco == pos[1])
        {
            uno = coco_pos.name;
        }
        else if (coco == pos[2])
        {
            tres = coco_pos.name;
        }
        else if (coco == pos[3])
        {
            cuatro = coco_pos.name;
        }
        else if (coco == pos[4])
        {
            cinco = coco_pos.name;
        }
        else if (coco == pos[5])
        {
            seis = coco_pos.name;
        }
        else if (coco == pos[6])
        {
            siete = coco_pos.name;
        }
        else if (coco == pos[7])
        {
            ocho = coco_pos.name;
        }

    }

    void imprimirPosiciones()
    {
        Debug.Log("primer lugar: " + uno);
        Debug.Log("segundo lugar: " + dos);
    }
}