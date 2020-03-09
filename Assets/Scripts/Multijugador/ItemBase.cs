using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class ItemBase : MonoBehaviourPun
{
    public int tiempoItems = 5;
    public int tiempoAtajo = 30;
    public int tiempoDeDesaparicion { set; private get; }
    private GameObject Atacante { set; get; }
    public int posicionAtacante { set; get; }

    public GameObject Afectado { set; get; }
    public int posicionAfectado { set; get; }

    private bool ItemTomado { set; get; }

    public virtual void Start()
    {
        Debug.Log("Soy el start de item base");
        StartCoroutine(DestruirObjeto());
    }

    public void TomarItem()
    {
        ItemTomado = true;
    }

    public IEnumerator DestruirObjeto()
    {        
        yield return new WaitForSeconds(tiempoDeDesaparicion);
        if (!ItemTomado)
            Destroy(gameObject);
    }

    public void ItemFlechas(string _atacante) 
    {
        Atacante = GameObject.Find(_atacante);
        posicionAtacante = Atacante.PositionInCareer();
        Vector3 pos_temp_Atacante = new Vector3(Atacante.transform.position.x, Atacante.transform.position.y);

        if (posicionAtacante != 1)
        {
            //Encontrar al jugador que va a ser afectado
            Afectado = GameObject.Find(RacingModeGameManager.instance.PosicionCarrera[posicionAtacante-1]);
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
