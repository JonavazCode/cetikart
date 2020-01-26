using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propiedades : MonoBehaviour
{
    public CheckpointsPerPJ cppj;
    public int cargas = 0;
    public int posicion;
    public int pos_anterior = 0;
    public int cargasPERdificultad = 0;
    public Dificultad niv_dif;
    // Start is called before the first frame update
    void Start()
    {
        
        niv_dif = FindObjectOfType<Dificultad>();

        if (niv_dif.nivel_dificultad == 1)
        {
            cargasPERdificultad = 2;
        }

        if (niv_dif.nivel_dificultad == 2)
        {
            cargasPERdificultad = 3;
        }

        if (niv_dif.nivel_dificultad == 3)
        {
            cargasPERdificultad = 4;
        }

    }

    // Update is called once per frame
    void Update()
    {
        cppj = FindObjectOfType<CheckpointsPerPJ>();
        posicion = posicion_carrera(gameObject.name);
        si_rebasa();
        posicion = posicion_carrera(gameObject.name);
        pos_anterior = posicion;
        cargas = limite_cargas(cargas);

    }

    void si_rebasa()
    {
        if ((pos_anterior != 0) && (pos_anterior > posicion))
        {
            cargas++;
        }
    }
    int limite_cargas(int carga)
    {
        if (carga > cargasPERdificultad)
            return cargasPERdificultad;
        else
            return carga;
    }

    int posicion_carrera(string nombre_personaje)
    {
        if (cppj.uno == this.name)
        {
            return 1;
        }
        else if (cppj.dos == this.name)
        {
            return 2;
        }
        else if (cppj.tres == this.name)
        {
            return  3;
        }
        else if (cppj.cuatro == this.name)
        {
            return  4;
        }
        else if (cppj.cinco == this.name)
        {
            return  5;
        }
        else if (cppj.seis == this.name)
        {
            return 6;
        }
        else if (cppj.siete == this.name)
        {
            return  7;
        }
        else
        {
            return 8;
        }

    }
}
