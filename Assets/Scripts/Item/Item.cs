using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    Propiedades cargasDeJugador;
    // Start is called before the first frame update
    void Start()
    {
        cargasDeJugador = FindObjectOfType<Propiedades>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string tag = collision.tag;
        if(tag == "Player")
        {
            cargasDeJugador.cargas++;

        }
        Debug.Log(tag);
        Destroy(gameObject);
       

        
    }

}
