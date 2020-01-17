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
    }

    public void OnTriggerEnter2D(Collider2D collision) {

        StartCoroutine(RegresarPosicion());

    }
    IEnumerator RegresarPosicion()
    {
        gameObject.transform.position = trash.transform.position;

        afectado = GameObject.Find(cppj.uno);
        var trans_afectado = afectado.transform.localScale;
        afectado.transform.localScale = new Vector3((trans_afectado.x *.5f), (trans_afectado.y * .5f), (trans_afectado.z * .5f));
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
        //afectado.transform.localScale = new Vector3(x_2, y_2, z_2);
        Debug.Log("se debería hacer grandote");
        afectado.transform.localScale = trans_afectado;
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
