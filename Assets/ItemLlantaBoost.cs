using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLlantaBoost : ItemBase, IItemActions
{

    public void MoverPosicionObjeto()
    {
        gameObject.transform.position = new Vector3(1000,1000);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Llanta boost");
        if (collision.tag == "Player")
        {
            TomarElItem();
            MoverPosicionObjeto();
            Action(collision.name);
        }
    }

    public void Action(string _atacante)
    {
        float boostVel = 1200f;
        Atacante = GameObject.Find(_atacante);
        Debug.Log("Velocidad boosteada.");
        Atacante.GetComponent<PhotonView>().RPC("ActualizarVelocidad", RpcTarget.All, boostVel);
        StartCoroutine(Esperar5segundos());

    }
    public IEnumerator Esperar5segundos()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("Velocidad normal");
        Atacante.GetComponent<PhotonView>().RPC("ActualizarVelocidad", RpcTarget.All, 1000f);
        Destruir();
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
    public override void Start()
    {
        PonerTiempoDesaparicion();
        base.Start();
    }

}
