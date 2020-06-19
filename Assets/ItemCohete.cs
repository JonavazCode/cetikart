using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCohete : ItemBase, IItemActions
{

    public void MoverPosicionObjeto()
    {
        gameObject.transform.position = new Vector3(1000, 1000);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Cohete");
        if (collision.CompareTag("Player"))
        {
            TomarElItem();
            MoverPosicionObjeto();
            Action(collision.name);
        }
    }

    public void Action(string _atacante)
    {
        setAtacante(_atacante);
        Debug.Log("Se puede volar!!");
        AVolar();
        StartCoroutine(Esperar5segundos());

    }
    public IEnumerator Esperar5segundos()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("Ya no se puede volar");
        AVolar();
        Destruir();
    }

    public void AVolar()
    {
        Atacante.GetComponent<CarMovement>().ControlesCohete();
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
