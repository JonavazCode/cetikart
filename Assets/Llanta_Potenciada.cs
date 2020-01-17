using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llanta_Potenciada : MonoBehaviour
{
    public GameObject trash;
    public KartController KC;



    // Start is called before the first frame update
    void Start()
    {
        trash = GameObject.Find("Trash");
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        StartCoroutine(RegresarPosicion(collision.name));

    }
    IEnumerator RegresarPosicion(string nombre_profesor)
    {
        int boost = 1200;
        int vel = 1000;
        gameObject.transform.position = trash.transform.position;
        var profesor = GameObject.Find(nombre_profesor);
        try
        {
            Debug.LogFormat("Velocidad jugador: {0}", boost);
            profesor.GetComponent<KartController>().speed = boost;
        }
        catch
        {
            Debug.Log("Afectando a enemigo");
            profesor.GetComponent<EnemyPath>().speed = boost;
        }
        yield return new WaitForSeconds(5);
        try
        {
            Debug.LogFormat("Velocidad jugador {0}", vel);
            profesor.GetComponent<KartController>().speed = vel;
        }
        catch
        {
            Debug.LogFormat("Velocidad enemigo {0}", vel);
            profesor.GetComponent<EnemyPath>().speed = vel;
        }
        Destroy(gameObject);


    }


}