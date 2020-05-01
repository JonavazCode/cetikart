using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            TomarItem();
            Flechas(collision.name);
            Destroy(gameObject);
        }
    }
    public void Flechas(string _atacante)
    {
        Atacante = GameObject.Find(_atacante);
        posicionAtacante = Atacante.PositionInCareer();
        Vector3 pos_temp_Atacante = new Vector3(Atacante.transform.position.x, Atacante.transform.position.y);

        if (posicionAtacante != 1)
        {
            //Encontrar al jugador que va a ser afectado
            Afectado = GameObject.Find(RacingModeGameManager.instance.PosicionCarrera[posicionAtacante - 1]);
            //guardar la posición del afectado
            Vector3 pos_temp_Afectado = new Vector3(Afectado.transform.position.x, Afectado.transform.position.y);
            //mover al atacante a la posicion del afectado en ese momento
            Atacante.GetComponent<PhotonView>().RPC("moverPj", RpcTarget.All, pos_temp_Afectado);

            //Mover al afectado a la posicion que tenía el atacante cuando tocó el item flechas
            Afectado.GetComponent<PhotonView>().RPC("moverPj", RpcTarget.All, pos_temp_Atacante);
            //Atacante.transform.position = new Vector3(Afectado.transform.position.x, Afectado.transform.position.y);
            //Afectado.transform.position = new Vector3(pos_temp_Atacante.x, pos_temp_Atacante.y);

            Debug.LogFormat("La posicion de {0} es: {1}. Se atacó a: {2}", Atacante.name, posicionAtacante, Afectado.name);
        }
        else
            Debug.Log("Lo tomó la primera posicion, no afectando a nada");
    }

}
