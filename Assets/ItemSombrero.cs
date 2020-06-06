using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSombrero : ItemBase, IItemActions
{
    public override void Start()
    {
        PonerTiempoDesaparicion();
        base.Start();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Item Sombrero");
        if (collision.tag == "Player")
        {
            TomarElItem();
            MoverPosicionObjeto();
            Action(collision.name);
        }
    }
    public void Action(string _atacante)
    {
        Atacante = GameObject.Find(_atacante);
        posicionAtacante = Atacante.PositionInCareer();

        if (posicionAtacante != 1)
        {
            Afectado = GameObject.Find(RacingModeGameManager.instance.PosicionCarrera[1]);
            Afectado.GetComponent<PhotonView>().RPC("AumentarEscala", RpcTarget.All, 0.5f);
            Afectado.GetComponent<PhotonView>().RPC("ActualizarVelocidad", RpcTarget.All, -400f);
            StartCoroutine(Esperar5segundos());
        }
        else
            return;
    }

    public IEnumerator Esperar5segundos()
    {
        yield return new WaitForSeconds(5);
        Afectado.GetComponent<PhotonView>().RPC("AumentarEscala", RpcTarget.All, 2f);
        Afectado.GetComponent<PhotonView>().RPC("ActualizarVelocidad", RpcTarget.All, 400f);
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

    public void CambiarEscala(GameObject jugador, float multiplicador)
    {
        jugador.GetComponent<PhotonView>().RPC("AumentarEscala", RpcTarget.All, multiplicador);
    }
}
