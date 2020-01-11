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
    public GameObject molina, coco, nino, ruben, sergio, ulyses, areli, susana, jugador;
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
        while (!carreraFinalizada)
        {
            
            asociarPosiciones();
            pos = new float[8];
            pos[0] = molina_pos.position.x;
            pos[1] = coco_pos.position.x;
            pos[2] = ruben_pos.position.x;
            pos[3] = areli_pos.position.x;
            pos[4] = susana_pos.position.x;
            pos[5] = nino_pos.position.x;
            pos[6] = sergio_pos.position.x;
            pos[7] = ulyses_pos.position.x;
            //pos[n] = nombreprofesor.position.x;

            float molina = pos[0], coco = pos[1], ruben = pos[2], areli = pos[3], susana = pos[4], nino = pos[5], sergio = pos[6], ulyses = pos[7];
            MetodoBurbuja(molina, coco, ruben, areli, susana, nino, sergio, ulyses);
            imprimirPosiciones();
            yield return new WaitForSeconds(2);
        }

    
    }

    public void asociarPosiciones()
    {


        molina_pos = GameObject.Find("molina_car") ?  GameObject.Find("molina_car").transform : GameObject.Find("molina_carE").transform;
        coco_pos = GameObject.Find("coco_car") ? GameObject.Find("coco_car").transform : GameObject.Find("coco_carE").transform;
        ruben_pos = GameObject.Find("agentek_car") ? GameObject.Find("agentek_car").transform : GameObject.Find("agentek_carE").transform;
        areli_pos = GameObject.Find("areli_car") ? GameObject.Find("areli_car").transform : GameObject.Find("areli_carE").transform;
        susana_pos = GameObject.Find("gussa_car") ? GameObject.Find("gussa_car").transform : GameObject.Find("gussa_carE").transform;
        nino_pos = GameObject.Find("nino_car") ? GameObject.Find("nino_car").transform : GameObject.Find("nino_carE").transform;
        sergio_pos = GameObject.Find("sergio_car") ? GameObject.Find("sergio_car").transform : GameObject.Find("sergio_carE").transform;
        ulyses_pos = GameObject.Find("ulyses_car") ? GameObject.Find("ulyses_car").transform : GameObject.Find("ulyses_carE").transform;

  

    }

    private void MetodoBurbuja(float molina, float coco, float ruben, float areli, float susana, float nino, float sergio, float ulyses)
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

        if (molina == pos[0])
        {
            ocho = molina_pos.name;
            
        }
        else if (molina == pos[1])
        {
            siete = molina_pos.name;
            
        }
        else if (molina == pos[2])
        {
            seis = molina_pos.name;
            
        }
        else if (molina == pos[3])
        {
            cinco = molina_pos.name;
            
        }
        else if (molina == pos[4])
        {
            cuatro = molina_pos.name;
            
        }
        else if (molina == pos[5])
        {
            tres = molina_pos.name;
           
        }
        else if (molina == pos[6])
        {
            dos = molina_pos.name;
            
        }
        else if (molina == pos[7])
        {
            uno = molina_pos.name;
            
        }


        if (coco == pos[0])
        {
            ocho = coco_pos.name;
        }
        else if (coco == pos[1])
        {
            siete = coco_pos.name;

        }
        else if (coco == pos[2])
        {
            seis = coco_pos.name;

        }
        else if (coco == pos[3])
        {
            cinco = coco_pos.name;

        }
        else if (coco == pos[4])
        {
            cuatro = coco_pos.name;

        }
        else if (coco == pos[5])
        {
            tres = coco_pos.name;

        }
        else if (coco == pos[6])
        {
            dos = coco_pos.name;

        }
        else if (coco == pos[7])
        {
            uno = coco_pos.name;

        }



        if (ruben == pos[0])
        {
            ocho = ruben_pos.name;
         
        }
        else if (ruben == pos[1])
        {
            siete = ruben_pos.name;
            
        }
        else if (ruben == pos[2])
        {
            seis = ruben_pos.name;
          
        }
        else if (ruben == pos[3])
        {
            cinco = ruben_pos.name;
         
        }
        else if (ruben == pos[4])
        {
            cuatro = ruben_pos.name;
            
        }
        else if (ruben == pos[5])
        {
            tres = ruben_pos.name;
          
        }
        else if (ruben == pos[6])
        {
            dos = ruben_pos.name;
         
        }
        else if (ruben == pos[7])
        {
            uno = ruben_pos.name;
 
        }

        #region areli
        if (areli == pos[0])
        {
            ocho = areli_pos.name;
          
        }
        else if (areli == pos[1])
        {
            siete = areli_pos.name;
            
        }
        else if (areli == pos[2])
        {
            seis = areli_pos.name;
           
        }
        else if (areli == pos[3])
        {
            cinco = areli_pos.name;
            
        }
        else if (areli == pos[4])
        {
            cuatro = areli_pos.name;
            
        }
        else if (areli == pos[5])
        {
            tres = areli_pos.name;
            
        }
        else if (areli == pos[6])
        {
            dos = areli_pos.name;
            
        }
        else if (areli == pos[7])
        {
            uno = areli_pos.name;
            
        }
        #endregion

        #region gussa
        if (susana == pos[0])
        {
            ocho = susana_pos.name;
            
        }
        else if (susana == pos[1])
        {
            siete = susana_pos.name;
           
        }
        else if (susana == pos[2])
        {
            seis = susana_pos.name;
            
        }
        else if (susana == pos[3])
        {
            cinco = susana_pos.name;
            
        }
        else if (susana == pos[4])
        {
            cuatro = susana_pos.name;
            
        }
        else if (susana == pos[5])
        {
            tres = susana_pos.name;
            
        }
        else if (susana == pos[6])
        {
            dos = susana_pos.name;
            
        }
        else if (susana == pos[7])
        {
            uno = susana_pos.name;
            
        }
        #endregion

        #region nino
        if (nino == pos[0])
        {
            ocho = nino_pos.name;
            
        }
        else if (nino == pos[1])
        {
            siete = nino_pos.name;
            
        }
        else if (nino == pos[2])
        {
            seis = nino_pos.name;
            
        }
        else if (nino == pos[3])
        {
            cinco = nino_pos.name;
            
        }
        else if (nino == pos[4])
        {
            cuatro = nino_pos.name;
            
        }
        else if (nino == pos[5])
        {
            tres = nino_pos.name;
            
        }
        else if (nino == pos[6])
        {
            dos = nino_pos.name;
            
        }
        else if (nino == pos[7])
        {
            uno = nino_pos.name;
            
        }
        #endregion

        #region sergio
        if (sergio == pos[0])
        {
            ocho = sergio_pos.name;
            
        }
        else if (sergio == pos[1])
        {
            siete = sergio_pos.name;
            
        }
        else if (sergio == pos[2])
        {
            seis = sergio_pos.name;
            
        }
        else if (sergio == pos[3])
        {
            cinco = sergio_pos.name;
            
        }
        else if (sergio == pos[4])
        {
            cuatro = sergio_pos.name;
            
        }
        else if (sergio == pos[5])
        {
            tres = sergio_pos.name;
            
        }
        else if (sergio == pos[6])
        {
            dos = sergio_pos.name;
            
        }
        else if (sergio == pos[7])
        {
            uno = sergio_pos.name;
            
        }
        #endregion

        #region ulyses
        if (ulyses == pos[0])
        {
            ocho = ulyses_pos.name;
           
        }
        else if (ulyses == pos[1])
        {
            siete = ulyses_pos.name;
           
        }
        else if (ulyses == pos[2])
        {
            seis = ulyses_pos.name;
            
        }
        else if (ulyses == pos[3])
        {
            cinco = ulyses_pos.name;
            
        }
        else if (ulyses == pos[4])
        {
            cuatro = ulyses_pos.name;
            
        }
        else if (ulyses == pos[5])
        {
            tres = ulyses_pos.name;
            
        }
        else if (ulyses == pos[6])
        {
            dos = ulyses_pos.name;
            
        }
        else if (ulyses == pos[7])
        {
            uno = ulyses_pos.name;
           
        }
        #endregion
    }

    void imprimirPosiciones()
    {
        /*
        Debug.Log("primer lugar: " + uno);
        Debug.Log("segundo lugar: " + dos);
        Debug.Log("tercer lugar: " + tres);
        Debug.Log("cuarto lugar: " + cuatro);
        Debug.Log("quinto lugar: " + cinco);
        Debug.Log("sexto lugar: " + seis);
        Debug.Log("septimo lugar: " + siete);
        Debug.Log("octavo lugar: " + ocho);
        */
    }
}