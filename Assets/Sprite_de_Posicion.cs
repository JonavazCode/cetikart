using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sprite_de_Posicion : MonoBehaviour
{
    public CheckpointsPerPJ cppj;
    public GameObject jugador;
    public Sprite posicion_1 = Resources.Load<Sprite>("Numeros_Posiciones_1");
    public Sprite posicion_2 = Resources.Load<Sprite>("Numeros_Posiciones_2");
    public Sprite posicion_3 = Resources.Load<Sprite>("Numeros_Posiciones_3");
    public Sprite posicion_4 = Resources.Load<Sprite>("Numeros_Posiciones_4");
    public Sprite posicion_5 = Resources.Load<Sprite>("Numeros_Posiciones_5");
    public Sprite posicion_6 = Resources.Load<Sprite>("Numeros_Posiciones_6");
    public Sprite posicion_7 = Resources.Load<Sprite>("Numeros_Posiciones_7");
    public Sprite posicion_8 = Resources.Load<Sprite>("Numeros_Posiciones_8");
    // Start is called before the first frame update
    void Start()
    {
        cppj = FindObjectOfType<CheckpointsPerPJ>();
        jugador = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
        if(cppj.ocho == jugador.name)
        {
            this.gameObject.GetComponent<Image>().sprite = posicion_8;
        }
        if (cppj.siete == jugador.name)
        {
            this.gameObject.GetComponent<Image>().sprite = posicion_7;
        }
        if (cppj.seis == jugador.name)
        {
            this.gameObject.GetComponent<Image>().sprite = posicion_6;
        }
        if (cppj.cinco == jugador.name)
        {
            this.gameObject.GetComponent<Image>().sprite = posicion_5;
        }
        if (cppj.cuatro == jugador.name)
        {
            this.gameObject.GetComponent<Image>().sprite = posicion_4;
        }
        if (cppj.tres == jugador.name)
        {
            this.gameObject.GetComponent<Image>().sprite = posicion_3;
        }
        if (cppj.dos == jugador.name)
        {
            this.gameObject.GetComponent<Image>().sprite = posicion_2;
        }
        if (cppj.uno == jugador.name)
        {
            this.gameObject.GetComponent<Image>().sprite = posicion_1;
        }

    }
}
