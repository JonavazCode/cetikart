using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cetikart.utilidades;

public class atajo : MonoBehaviour
{
    public LevelManager levelManager; //instancia de LevelManager
    public bool a_la_meta = false;
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>(); //encuentra el objeto LevelManager
        irAMeta();
        StartCoroutine(DestruirObjeto());
    }
    IEnumerator DestruirObjeto()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }

    public void irAMeta()
    {
        if (this.gameObject.transform.position == levelManager.checkPoints[levelManager.checkPoints.Length - 2].transform.position)
        {
            a_la_meta = true;
            Debug.Log("Sí está en el antepenúltimo checkpoint!!!");
        }
        else
            Debug.Log("No está en el antepenúltimo checkpoint");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (esPersonaje(other.name) && a_la_meta)
        {
            try
            {
                GameObject meta = GameObject.Find("Checkpoint_META");
                other.transform.position = meta.transform.position;
            }
            catch
            {
                Debug.LogError("No hay checkpoint_META. Ponerlo desde la carpeta prefabs>items>entorno");
            }
        }   

        if (esPersonaje(other.name) && !a_la_meta)
        {
            int checkpoint_index = levelManager.cppj.checkpoint_actual_jugador(other.name, levelManager.checkPoints);
            try
            {
                Debug.Log("En el try");
                other.transform.position = levelManager.checkPoints[checkpoint_index + 4].transform.position;
            }
            catch
            {
                Debug.Log("En el catch");
                other.transform.position = levelManager.checkPoints[checkpoint_index + 2].transform.position;
            }

            
        }
        Destroy(gameObject);
    }

    private bool esPersonaje(string nombre)
    {
        if (nombre.Contains("agentek") || nombre.Contains("areli") || nombre.Contains("coco") || nombre.Contains("gussa") || nombre.Contains("molina") || nombre.Contains("nino") || nombre.Contains("sergio") || nombre.Contains("ulyses"))
        {
            return true;
        }
        else
            return false;
    }
}
