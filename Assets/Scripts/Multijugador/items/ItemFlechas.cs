using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ItemFlechas : ItemBase
{
    public override void Start()
    {
        tiempoDeDesaparicion = tiempoItems;
        base.Start();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Item Flechas");
        if (collision.tag == "Player")
        {
            //TomarItem();
            RPC("ItemFlechas", RpcTarget.AllBuffered, collision.gameObject);
            Destroy(gameObject);
        }
    }

}
