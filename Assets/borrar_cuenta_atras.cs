using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class borrar_cuenta_atras : MonoBehaviour
{
    float tiempo_start = 0; //Los segundos por los quales comienza i la variable que utilizaremos para que vaya contando segundos.
    float tiempo_end = 4; //Segundos que queremos que pasen para que cambie de escena.

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tiempo_start += Time.deltaTime;//Función para que la variable tiempo_start vaya contando segundos.
        if (tiempo_start >= tiempo_end) //Si pasan los segundos que hemos puesto antes...
        {
            this.gameObject.SetActive(false);
        }


    }
}
