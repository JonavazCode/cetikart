using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cohete : MonoBehaviour
{
    public KartController kc;
    public GameObject trash;

    void Start()
    {
        trash = GameObject.Find("Trash");
        kc = FindObjectOfType<KartController>();
        StartCoroutine(DestruirObjeto());
    }
    IEnumerator DestruirObjeto()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        string nombre_profesor = collision.name;
        var rb2d_profesor = GameObject.Find(nombre_profesor).GetComponent<Rigidbody2D>();
        StartCoroutine(RegresarPosicion(rb2d_profesor));
        
    }
    IEnumerator RegresarPosicion(Rigidbody2D profesor)
    {
        gameObject.transform.position = trash.transform.position;
        //profesor.gravityScale = -3f;
        
        kc.item_cohete_fly = !kc.item_cohete_fly;
        yield return new WaitForSeconds(5);
        kc.item_cohete_fly = !kc.item_cohete_fly;
        Debug.Log("cohetazo");
       // profesor.gravityScale = 1f;
        Destroy(gameObject);
    }   
}

