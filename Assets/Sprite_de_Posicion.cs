using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sprite_de_Posicion : MonoBehaviour
{
    public CheckpointsPerPJ Num_Pos;
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
        Num_Pos = FindObjectOfType<CheckpointsPerPJ>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Num_Pos.Sprite_Pos == 8)
        {
            this.gameObject.GetComponent<Image>().sprite = posicion_8;
        }
        if (Num_Pos.Sprite_Pos == 7)
        {
            this.gameObject.GetComponent<Image>().sprite = posicion_7;
        }
        if (Num_Pos.Sprite_Pos == 6)
        {
            this.gameObject.GetComponent<Image>().sprite = posicion_6;
        }
        if (Num_Pos.Sprite_Pos == 5)
        {
            this.gameObject.GetComponent<Image>().sprite = posicion_5;
        }
        if (Num_Pos.Sprite_Pos == 4)
        {
            this.gameObject.GetComponent<Image>().sprite = posicion_4;
        }
        if (Num_Pos.Sprite_Pos == 3)
        {
            this.gameObject.GetComponent<Image>().sprite = posicion_3;
        }
        if (Num_Pos.Sprite_Pos == 2)
        {
            this.gameObject.GetComponent<Image>().sprite = posicion_2;
        }
        if (Num_Pos.Sprite_Pos == 1)
        {
            this.gameObject.GetComponent<Image>().sprite = posicion_1;
        }

    }
}
