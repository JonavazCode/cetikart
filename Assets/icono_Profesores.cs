using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class icono_Profesores : MonoBehaviour
{
    public Historial profesor;
    public Sprite profesor_ulyses = Resources.Load<Sprite>("Profesor_Ulyses_Boton");
    public Sprite profesor_rene = Resources.Load<Sprite>("Profesor_Ruben_Boton");
    public Sprite profesor_areli = Resources.Load<Sprite>("Profesor_Areli_Boton");
    public Sprite profesor_ismael = Resources.Load<Sprite>("Profesor_Coco_Boton");
    public Sprite profesor_sergio = Resources.Load<Sprite>("Profesor_Sergio_Boton");
    public Sprite profesor_nino = Resources.Load<Sprite>("Profesor_Niño_Boton");
    public Sprite profesor_molina = Resources.Load<Sprite>("Profesor_Molina_Boton");
    public Sprite profesor_susana = Resources.Load<Sprite>("Profesor_Susana_Boton");
    // Start is called before the first frame update
    void Start()
    {
        profesor = FindObjectOfType<Historial>();
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
