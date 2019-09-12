using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject currentCheckPoint, checkPointRandom; //checkpoint actual, checkpoint elegido aleatoriamente
    public List<GameObject> checkPoints; //lista de checkpoints colectados
    private Movimiento_Profesor_Molina player; //jugador

    private float gameTimer = -3f; //tiempo de juego
    public int timeCount; // conversion a segundos


    public GameObject[] obj;//variable para instanciar los objetos
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Movimiento_Profesor_Molina>();
    }

    // Update is called once per frame
    void Update()
    {

        gameTimer += Time.deltaTime;
        timeCount = (int) (gameTimer % 60);

        if (timeCount == 5) //al pasar 5 segundos se genera un item
        {

            gameTimer = 0f;
            Debug.Log("spawn item");
            GenerarItems();


            
        }

    }


    public void RespawnPlayer()
    {
        Debug.Log("Player Respawn");
        player.transform.position = currentCheckPoint.transform.position; //posición del jugador ahora es la posición del último checkpoint que pasó
    }
    public void GenerarItems()
    {
        
        int randomPosition = Random.Range(0, checkPoints.Count); //numero random entre 0 y el número de checkpoints de la pista
        checkPointRandom = checkPoints[randomPosition]; //Instancia de checkpoint random
        int randomRange = Random.Range(0, obj.Length); //numero random entre 0 y el numero de objetos existentes
        Instantiate(obj[randomRange], transform.position = checkPointRandom.transform.position, Quaternion.identity); //posicionar el item en el checkpoint random
        

    }

}
