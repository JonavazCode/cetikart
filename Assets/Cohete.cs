using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cohete : MonoBehaviour
{
    public Rigidbody2D profesor;
    public GameObject trash;
   



    // Start is called before the first frame update
    void Start()
    {
        trash = GameObject.Find("Trash");
    }

    // Update is called once per frame
    void Update()
    {

      
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        StartCoroutine(RegresarPosicion());
        
    }
    IEnumerator RegresarPosicion()
    {
        gameObject.transform.position = trash.transform.position;
        profesor.gravityScale = -2f;
        yield return new WaitForSeconds(5);
        Debug.Log("Llego");
        profesor.gravityScale = 1f;
        Destroy(gameObject);


    }

   
}

