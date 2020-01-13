using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Historial : MonoBehaviour
{
    public int numero;
    public Text historial;


    private Checkpoint_Meta cpm;

    // Start is called before the first frame update
    void Start()
    {
        cpm = FindObjectOfType<Checkpoint_Meta>();
        MostrarJugadores();
    }


    void MostrarJugadores()
    {
        
        foreach (string jugador in cpm.jugadores)
        {
            Debug.Log(jugador);
            numero++;

            //historial.text += "\n" + numero + "° Lugar: Profesor " + (jugador.Contains("_carE")? jugador.Replace("_carE", " (BOT)") : jugador.Replace("_car", " (Tú)"));
            historial.text += "\n" + numero + "° Lugar: " + nombre_profesor(jugador) + jugador_o_bot(jugador);
        } 
    }

    string nombre_profesor(string nombre)
    {
        if (nombre.Contains("molina"))
        {
            return nombre = "Profesor Molina";
        }
        else if (nombre.Contains("ulyses"))
        {
            return nombre = "Profesor Ulyses";
        }
        else if (nombre.Contains("sergio"))
        {
            return nombre = "Profesor Sergio";
        }
        else if (nombre.Contains("nino"))
        {
            return nombre = "Profesor Niño";
        }
        else if (nombre.Contains("gussa"))
        {
            return nombre = "Profesora Susana";
        }
        else if (nombre.Contains("coco"))
        {
            return nombre = "Profesor Ismael";
        }
        else if (nombre.Contains("areli"))
        {
            return nombre = "Profesora Areli";
        }
        else
        {
            return nombre = "Profesor Ulyses";

        }

    }

    string jugador_o_bot(string nombre)
    {

        return nombre.Contains("_carE") ? " (BOT)" : " (TÚ)";
    }
}
