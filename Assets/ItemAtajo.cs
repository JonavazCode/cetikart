using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAtajo : ItemBase, IItemActions
{
    public override void Start()
    {
        PonerTiempoDesaparicion();
        base.Start();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Item Atajo");
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
        var AtacanteLapController = Atacante.GetComponent<LapController>();
        var NumeroCheckpointsTotal = Atacante.GetComponent<LapController>().Checkpoints.Count;
        var CheckpointActual = AtacanteLapController.NumeroCheckpointActual;
       
        if ((CheckpointActual + 2) >= NumeroCheckpointsTotal)
        {
            Debug.Log("Sobrepasa el numero de checkpoints");
            Vector3 pos =  new Vector3(AtacanteLapController.Checkpoints[NumeroCheckpointsTotal - 1].transform.position.x , AtacanteLapController.Checkpoints[NumeroCheckpointsTotal - 1].transform.position.y);
            Atacante.GetComponent<PhotonView>().RPC("moverPj", RpcTarget.All, pos);
        }
        else
        {
            Debug.Log("En el siguiente atajo");
            Vector3 pos = new Vector3(AtacanteLapController.Checkpoints[CheckpointActual + 3].transform.position.x, AtacanteLapController.Checkpoints[CheckpointActual + 3].transform.position.y);
            Atacante.GetComponent<PhotonView>().RPC("moverPj", RpcTarget.All, pos);
        }



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
