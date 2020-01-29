using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llanta_Potenciada : MonoBehaviour
{
    public GameObject trash;
    public KartController KC;
    public bool ItemTomado = false;



    // Start is called before the first frame update
    void Start()
    {
        trash = GameObject.Find("Trash");
        StartCoroutine(DestruirObjeto());
        
    }
    IEnumerator DestruirObjeto()
    {
        yield return new WaitForSeconds(5);
        if (!ItemTomado)
            Destroy(gameObject);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        ItemTomado = true;
        StartCoroutine(RegresarPosicion(collision.name));

    }
    IEnumerator RegresarPosicion(string nombre_profesor)
    {
        int boost = 1200;
        int vel = 1000;
        gameObject.transform.position = trash.transform.position;
        var profesor = GameObject.Find(nombre_profesor);
        Debug.LogFormat("Llanta ponchada profesor encontrado: {0}", profesor.name);
        try
        {
            Debug.LogFormat("Velocidad jugador: {0}", boost);
            profesor.GetComponent<KartController>().speed = boost;
        }
        catch
        {
            try
            {
                Debug.Log("Afectando a enemigo");
                profesor.GetComponent<EnemyPath>().speed = boost;
            }
            catch {
                Debug.Log("No se encuentra referencia a jugador o bot");
            }
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