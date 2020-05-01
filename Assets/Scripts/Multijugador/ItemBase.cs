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
}
