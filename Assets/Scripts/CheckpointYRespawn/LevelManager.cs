using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject checkPointRandom, checkPoint5; //checkpoint actual, checkpoint elegido aleatoriamente
    public GameObject[] checkPoints; //lista de checkpoints colectados
    private Movimiento_Profesor_Molina player; //jugador

    public int timeCount; // conversion a segundos

    public GameObject[] obj;//variable para instanciar los objetos

    #region flags

    private bool firstFlag = false; //bandera de espera para los items

    #endregion

    void Start()
    {
        player = FindObjectOfType<Movimiento_Profesor_Molina>();
        checkPoints = GameObject.FindGameObjectsWithTag("Checkpoint");
        acomodar();
        StartCoroutine(GenerarItems());
        

    }

    // Update is called once per frame
    void Update()
    {
   
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
        //player.transform.position = currentCheckPoint.transform.position; //posición del jugador ahora es la posición del último checkpoint que pasó
    }

    IEnumerator GenerarItems()
    {
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
                int randomPosition = Random.Range(0, checkPoints.Length); //numero random entre 0 y el número de checkpoints de la pista
                checkPointRandom = checkPoints[randomPosition]; //Instancia de checkpoint random
                int randomRange = Random.Range(0, obj.Length); //numero random entre 0 y el numero de objetos existentes
                Instantiate(obj[randomRange], transform.position = checkPointRandom.transform.position, Quaternion.identity); //posicionar el item en el checkpoint random
                yield return new WaitForSeconds(5);
            }
            
        }
       
       
    }

    public void Atajo()
    {
        Debug.Log("Atajo");
        player.transform.position = checkPoint5.transform.position;

    }

}
