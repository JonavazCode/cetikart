using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    Propiedades cargasDeJugador;
    Propiedades_Bots cargasDeBot;
    // Start is called before the first frame update
    void Start()
    {
        cargasDeBot = FindObjectOfType<Propiedades_Bots>();
        cargasDeJugador = FindObjectOfType<Propiedades>();
        StartCoroutine(DestruirObjeto());
    }
    IEnumerator DestruirObjeto()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string tag = collision.tag;
        if(tag == "Player")
        {
            cargasDeJugador.cargas++;
            
        }
        if(tag == "Enemy")
            cargasDeBot.CargasBots++;
        Destroy(gameObject);   
    }
}
