using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llanta_Potenciada : MonoBehaviour
{
    public GameObject profesor;
    public GameObject trash;
    public KartController KC;



    // Start is called before the first frame update
    void Start()
    {
        trash = GameObject.Find("Trash");
        KC = FindObjectOfType<KartController>();
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
        KC.speed = 1700;
        yield return new WaitForSeconds(5);
        KC.speed = 1000;
        Destroy(gameObject);


    }


}