using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public GameObject profesor;
    private Vector3 posicion;
    private Rigidbody2D molina;
    // Start is called before the first frame update
    void Start()
    {
        posicion = transform.position - molina.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = molina.transform.position + posicion;
    }
}
