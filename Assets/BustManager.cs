using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BustManager : MonoBehaviour
{
    float tiempo_start = 0; 
    float tiempo_end = 8;
    float tiempo_start2 = 0;
    float tiempo_end2 = 2;
    public GameObject bust;
    public KartController velocidad;
    float bustAgregado = 2000f;
    public GameObject aumento;
    
    
    // Start is called before the first frame update
    public void Start()
    {
        velocidad = FindObjectOfType<KartController>();

        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo_start += Time.deltaTime;
        tiempo_start2 += Time.deltaTime;
        if (tiempo_start >= tiempo_end) //Si pasan los segundos que hemos puesto antes...
        {
            velocidad.speed = velocidad.speedPERdif;
            bust.SetActive(false);
        }

        if (tiempo_start2 >= tiempo_end2) //Si pasan los segundos que hemos puesto antes...
        {
            aumento.SetActive(false);
        }

    }

    public void GenerarBust()
    {
        
        velocidad.speed = velocidad.speed + 2000f;
        aumento.SetActive(false);
        
    }
  
}   

