using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class LogoCeti : ItemBase
{
    public override void Start()
    {
        tiempoDeDesaparicion = tiempoItems;
        base.Start();      
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Item LogoCeti");
        if (collision.tag == "Player")
        {
            //TomarItem();
            Destroy(gameObject);
        }
    }

}
