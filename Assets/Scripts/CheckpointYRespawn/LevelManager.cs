using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cetikart.utilidades;
public class LevelManager : MonoBehaviour
{
    public GameObject checkPointRandom; //checkpoint actual
    public GameObject[] checkPoints; //lista de checkpoints colectados
    public int timeCount; // conversion a segundos
    public GameObject[] obj;//variable para instanciar los objetos

    public CheckpointsPerPJ cppj;

    #region flags

    private bool firstFlag = false; //bandera de espera para los items

    #endregion

    void Start()
    {
        //checkPoints = GameObject.FindGameObjectsWithTag("Checkpoint");
        cppj = FindObjectOfType<CheckpointsPerPJ>();
        //acomodar();
        StartCoroutine(GenerarItems());
    }


    private void acomodar()
    {
        GameObject[] cps = new GameObject[checkPoints.Length];

        int x = checkPoints.Length; //5
        int temp = x - 1; //4

        for (int i = 0; i < x; i++)
        {
            cps[i] = checkPoints[temp]; //cps[4] checkpints[0]
            temp--;
        }

        checkPoints = cps;
    }

    public void RespawnPlayer(string pjName, GameObject currentCheckpoint)
    {
       Debug.Log("Nombre del  personaje: " + pjName);
       Debug.Log("nombre del checkpoint: " + currentCheckpoint.name);
       GameObject pj = GameObject.Find(pjName);
       pj.transform.position = currentCheckpoint.transform.position;
    }

    IEnumerator GenerarItems()
    {
        int contador_puerta = 0;
        while (true)
        {
            if (!firstFlag)
            {
                firstFlag = true;
                yield return new WaitForSeconds(5);
            }
            else
            {
                Debug.Log("Generar item");
                if (contador_puerta == 5)
                {
                    Debug.Log("Objeto puerta va a spawnear");
                }
                int inicia = cppj.checkpoint_actual_jugador(cppj.uno, checkPoints);
                int termina = cppj.checkpoint_actual_jugador(cppj.ocho, checkPoints);
                Debug.Log(termina);
                Debug.Log(inicia);
                int randomPosition = Random.Range(termina, inicia); //numero random entre 0 y el número de checkpoints de la pista
                checkPointRandom = checkPoints[randomPosition]; //Instancia de checkpoint random
                int randomRange = Random.Range(0, obj.Length); //numero random entre 0 y el numero de objetos existentes
                Instantiate(obj[randomRange], transform.position = checkPointRandom.transform.position, Quaternion.identity); //posicionar el item en el checkpoint random
                yield return new WaitForSeconds(5);
                contador_puerta++;
            }
            
        }
       
       
    }


}
