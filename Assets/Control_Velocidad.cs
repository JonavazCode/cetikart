using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_Velocidad : MonoBehaviour
{
    public Animator Velocimetro;
    public float velocidad_profesor;
    public Movimiento_Profesor_Molina Velocidad;
    // Start is called before the first frame update
    void Start()
    {
        Velocimetro.GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        Velocimetro.SetFloat("Velocidad", Velocidad.h); 
        
    }
}
