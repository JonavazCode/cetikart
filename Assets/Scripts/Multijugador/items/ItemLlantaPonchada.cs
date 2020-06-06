using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLlantaPonchada : ItemBase, IItemActions
{
    public override void Start()
    {
        PonerTiempoDesaparicion();
        base.Start();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Item Llanta Ponchada");
        if (collision.tag == "Player")
        {
            TomarElItem();
            MoverPosicionObjeto();
            Action(collision.name);
        }
    }
    public void Action(string _atacante)
    {
        setAtacante(_atacante);
        posicionAtacante = Atacante.PositionInCareer();

        if (posicionAtacante != 1)
        {
            //Encontrar al jugador que va a ser afectado
            Afectado = GameObject.Find(RacingModeGameManager.instance.PosicionCarrera[posicionAtacante - 1]);
            Afectado.GetComponent<PhotonView>().RPC("ActualizarVelocidad", RpcTarget.All, -1000f);
            StartCoroutine(Esperar5segundos());
        }
        else
            return;
    }

    public IEnumerator Esperar5segundos()
    {
        yield return new WaitForSeconds(5);
        //Debug.Log("Velocidad normal");
        Afectado.GetComponent<PhotonView>().RPC("ActualizarVelocidad", RpcTarget.All, 1000f);
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
    public void MoverPosicionObjeto()
    {
        gameObject.transform.position = new Vector3(1000, 1000);
    }
}
