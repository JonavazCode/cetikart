using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class ItemBase : MonoBehaviourPun
{
    public int tiempoItems = 5;
    public int tiempoAtajo = 30;
    public int tiempoDeDesaparicion { set; private get; }
    public GameObject Atacante { set; get; }
    public int posicionAtacante { set; get; }

    public GameObject Afectado { set; get; }
    public int posicionAfectado { set; get; }

    private bool ItemTomado { set; get; }

    public virtual void Start()
    {
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

    public void setAtacante(string NombreAtacante)
    {
        Atacante = GameObject.Find(NombreAtacante);
    }

    public void setAfectado(string NombreAfectado)
    {
        Afectado = GameObject.Find(NombreAfectado);
    }
    public void updateVelocidadAtacante(GameObject Atacante, float velocidad)
    {
        Atacante.GetComponent<PhotonView>().RPC("ActualizarVelocidad", RpcTarget.All, velocidad);
    }
}
