using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cetikart.utilidades;
public class LevelManager : MonoBehaviour
{
    public GameObject checkPointRandom, checkPointRandomAtajo; //checkpoint actual
    public GameObject[] checkPoints; //lista de checkpoints colectados
    public int timeCount; // conversion a segundos
    public GameObject[] obj;//variable para instanciar los objetos

    public CheckpointsPerPJ cppj;

    #region flags

    private bool firstFlag = false; //bandera de espera para los items
    private bool firstFlagAtajo = false; //bandera de espera para los atajos

    #endregion

    void Start()
    {
        cppj = FindObjectOfType<CheckpointsPerPJ>();
        StartCoroutine(GenerarItems());
        StartCoroutine(GenerarAtajo());
    }

    /*
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
    */
    public void RespawnPlayer(string pjName, GameObject currentCheckpoint)
    {
       Debug.Log("Nombre del  personaje: " + pjName);
       Debug.Log("nombre del checkpoint: " + currentCheckpoint.name);
       GameObject pj = GameObject.Find(pjName);
       pj.transform.position = currentCheckpoint.transform.position;
    }

    IEnumerator GenerarAtajo()
    {
        int inicia;
        int termina;
        int randomPosition;
        while (true)
        {
            if (!firstFlagAtajo)
            {
                firstFlagAtajo = true;
                yield return new WaitForSeconds(10);
            }
            else
            {
                inicia = cppj.checkpoint_actual_jugador(cppj.uno, checkPoints);
                termina = cppj.checkpoint_actual_jugador(cppj.ocho, checkPoints);
                randomPosition = Random.Range(termina, inicia); //numero random entre 0 y el número de checkpoints de la pista
                checkPointRandomAtajo = checkPoints[checkPoints.Length-2]; //Instancia de checkpoint random
                Instantiate(obj[6], transform.position = checkPointRandomAtajo.transform.position, Quaternion.identity); //posicionar el item en el checkpoint random
                yield return new WaitForSeconds(10);

            }

        }

    }
    IEnumerator GenerarItems()
    {
        int inicia;
        int termina;
        int randomPosition;

        while (true)
        {
            if (!firstFlag)
            {
                firstFlag = true;
                yield return new WaitForSeconds(5);
            }
            else
            {
                    inicia = cppj.checkpoint_actual_jugador(cppj.uno, checkPoints);
                    termina = cppj.checkpoint_actual_jugador(cppj.ocho, checkPoints);
                    randomPosition = Random.Range(termina, inicia); //numero random entre 0 y el número de checkpoints de la pista
                    checkPointRandom = checkPoints[randomPosition]; //Instancia de checkpoint random
                    int randomRange = Random.Range(0, obj.Length-1); //numero random entre 0 y el numero de objetos existentes
                    Debug.LogFormat("item numero: {0} de la lista", randomRange);
                    Instantiate(obj[randomRange], transform.position = checkPointRandom.transform.position, Quaternion.identity); //posicionar el item en el checkpoint random
                    yield return new WaitForSeconds(5);
               
            }
            
        }
       
       
    }



}
