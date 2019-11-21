using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flechas : MonoBehaviour
{
    public GameObject profesor;
    public GameObject afectado;
    public GameObject trash;
    public Vector3 PosTemp;
   



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

        PosTemp = profesor.transform.position;
        profesor.transform.position = new Vector3 (afectado.transform.position.x, afectado.transform.position.y);
        afectado.transform.position = new Vector3 (PosTemp.x, PosTemp.y);
        Destroy(gameObject);
    }


}