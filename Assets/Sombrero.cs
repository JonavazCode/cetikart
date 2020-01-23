using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sombrero : MonoBehaviour
{
    public GameObject afectado;
    public GameObject trash;
    public CheckpointsPerPJ cppj;

    // Start is called before the first frame update
    void Start()
    {
        cppj = FindObjectOfType<CheckpointsPerPJ>();
        trash = GameObject.Find("Trash");
        StartCoroutine(DestruirObjeto());
    }
    IEnumerator DestruirObjeto()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }

    public void OnTriggerEnter2D(Collider2D collision) {

        StartCoroutine(RegresarPosicion());

    }
    IEnumerator RegresarPosicion()
    {
        gameObject.transform.position = trash.transform.position;

        afectado = GameObject.Find(cppj.uno);
        float posicion_afectado = afectado.transform.position.y;
        afectado.transform.localScale = new Vector3((afectado.transform.localScale.x *.5f), (afectado.transform.localScale.y * .5f), (afectado.transform.localScale.z * .5f));
        try
        {
            Debug.Log("Sombrero afectando a enemigo");
            afectado.GetComponent<EnemyPath>().speed = 500;
        }
        catch
        {
            Debug.Log("Sombrero afectando a aliado");
            afectado.GetComponent<KartController>().speed = 500;
        }
        
        yield return new WaitForSeconds(5);
        Debug.Log("se debería hacer grandote");
        afectado.transform.localScale = new Vector3((afectado.transform.localScale.x * 2f), (afectado.transform.localScale.y * 2f), (afectado.transform.localScale.z * 2f));
        afectado.transform.localPosition = new Vector3(afectado.transform.position.x, posicion_afectado);
        try
        {
            Debug.Log("");
            afectado.GetComponent<EnemyPath>().speed = 1000;
        }
        catch
        {
            Debug.Log("");
            afectado.GetComponent<KartController>().speed = 1000;
        }
        Destroy(gameObject);


    }
}
