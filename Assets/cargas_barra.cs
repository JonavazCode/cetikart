using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class cargas_barra : MonoBehaviour
{
    private Animator animacion;
    private CircleCollider2D logo;
    public int cargas = 0;

    // Start is called before the first frame update
    void Start()
    {
        animacion = GetComponent<Animator>();
        logo = GetComponent<CircleCollider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Cola");
        if (col.transform.tag == "Profesor_Molina")
        {

            this.gameObject.SetActive(false);
            cargas++;

        }
    }
}
