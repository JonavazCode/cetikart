using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llanta_Ponchada : MonoBehaviour
{
    public GameObject afectado;
    public GameObject trash;
    public EnemyPath EP;



    // Start is called before the first frame update
    void Start()
    {
        trash = GameObject.Find("Trash");
        EP = FindObjectOfType<EnemyPath>();
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
        EP.speed = 0;
        yield return new WaitForSeconds(5);
        EP.speed = 1000;
        Destroy(gameObject);


    }


}
