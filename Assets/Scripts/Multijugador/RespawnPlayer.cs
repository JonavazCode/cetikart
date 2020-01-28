using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GameObject pj = GameObject.Find(other.name);
            var IndexSiguienteCheckpoint = pj.GetComponent<LapController>().NumeroCheckpointActual;
            //IndexSiguienteCheckpoint++;
            pj.transform.position = pj.GetComponent<LapController>().Checkpoints[IndexSiguienteCheckpoint].transform.position;
        }
        

    }
}
