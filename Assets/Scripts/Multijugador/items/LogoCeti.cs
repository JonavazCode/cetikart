using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class LogoCeti : ItemBase, IItemActions
{

    public override void Start()
    {
        PonerTiempoDesaparicion();
        base.Start();      
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Item LogoCeti");
        if (collision.tag == "Player")
        {
            TomarElItem();
            Action(collision.gameObject);
            Destruir();

        }
    }

    public void Action(GameObject jugador)
    {
        jugador.GetComponent<PhotonView>().RPC("AumentarCargas", RpcTarget.All);
    }
    public void PonerTiempoDesaparicion()
    {
        tiempoDeDesaparicion = tiempoItems;
    }
    public void Destruir()
    {
        Destroy(gameObject);
    }

    public void TomarElItem()
    {
        TomarItem();
    }
}
