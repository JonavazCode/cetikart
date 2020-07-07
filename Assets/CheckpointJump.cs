using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointJump : MonoBehaviour
{
    public EnemyPath puedeSaltar;
    // Start is called before the first frame update
    void Start()
    {
        puedeSaltar = FindObjectOfType<EnemyPath>();   
    }

    // Update is called once per frame
    void Update()
    {   
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string tag = collision.tag;
        if (tag == "Enemy")
        {
            puedeSaltar.canJump = false;
            collision.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            collision.GetComponent<Rigidbody2D>().AddForce(new Vector2(500f, 1000f));

        }

    }
}
