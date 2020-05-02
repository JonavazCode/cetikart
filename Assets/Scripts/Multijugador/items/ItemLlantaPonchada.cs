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
            Destruir();
        }
    }
    public void Action(string _atacante)
    {
        Atacante = GameObject.Find(_atacante);
        posicionAtacante = Atacante.PositionInCareer();

        if (posicionAtacante != 1)
        {
            //Encontrar al jugador que va a ser afectado
            Afectado = GameObject.Find(RacingModeGameManager.instance.PosicionCarrera[posicionAtacante - 1]);
            Afectado.GetComponent<PhotonView>().RPC("ActualizarVelocidad", RpcTarget.All, 0f);
            StartCoroutine(Esperar5segundos());
            Debug.LogFormat("La posicion de {0} es: {1}. Se atacó a: {2}", Atacante.name, posicionAtacante, Afectado.name);
        }
        else
            Debug.Log("Lo tomó la primera posicion, no afectando a nada");
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
    public void MoverPosicionObjeto()
    {
        gameObject.transform.position = new Vector3(1000, 1000);
    }
}
