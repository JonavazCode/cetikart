using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sombrero : MonoBehaviour
{
    public GameObject afectado;
    public GameObject trash;
    public float x = -1;
    public float y = -1;
    public float z = -1;
    public float x_2 = 1;
    public float y_2 = 1;
    public float z_2 = 1;
    public EnemyPath EP;

    // Start is called before the first frame update
    void Start()
    {
        EP = FindObjectOfType<EnemyPath>();
        trash = GameObject.Find("Trash");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision) {

        StartCoroutine(RegresarPosicion());

    }
    IEnumerator RegresarPosicion()
    {
        gameObject.transform.position = trash.transform.position;
        afectado.transform.localScale = new Vector3(x, y, z);
        EP.speed = 500;
        yield return new WaitForSeconds(5);
        afectado.transform.localScale = new Vector3(x_2, y_2, z_2);
        EP.speed = 1000;
        Destroy(gameObject);


    }
}
