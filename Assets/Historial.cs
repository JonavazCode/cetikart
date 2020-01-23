using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //Con esta libreria es posiible controlar el cambio entre scenas dentro del juego
/// <summary>
/// Esta clase es la encargada de mostrar las posiciones de los jugadores al final de la carrera.
/// </summary>
public class Historial : MonoBehaviour
{
    public int numero;
    public Text historial;


    private Checkpoint_Meta cpm;

    void Start()
    {
        cpm = FindObjectOfType<Checkpoint_Meta>();
        MostrarJugadores();
    }
    /// <summary>
    /// Función para mostrar la lista de jugadores
    /// </summary>
    void MostrarJugadores()
    {

        foreach (string jugador in cpm.jugadores)
        {
            numero++;
            historial.text += "\n" + numero + "° Lugar: " + nombre_profesor(jugador) + jugador_o_bot(jugador);
        } 
    }
    /// <summary>
    /// Este método es el encargado de regresar un nombre "estético" de acuerdo al nombre de objeto que recibe por argumento
    /// </summary>
    /// <param name="nombre"> Nombre del personaje </param>
    /// <returns>Retorna un string personalizado de acuerdo al argumento envíado en el siguiente formato "Profesor(a) NombreProfesor" </returns>
    string nombre_profesor(string nombre)
    {
        if (nombre.Contains("molina"))
        {
            return "Profesor Molina";
        }
        else if (nombre.Contains("ulyses"))
        {
            return "Profesor Ulyses";
        }
        else if (nombre.Contains("sergio"))
        {
            return "Profesor Sergio";
        }
        else if (nombre.Contains("nino"))
        {
            return "Profesor Niño";
        }
        else if (nombre.Contains("gussa"))
        {
            return "Profesora Susana";
        }
        else if (nombre.Contains("coco"))
        {
            return "Profesor Ismael";
        }
        else if (nombre.Contains("areli"))
        {
            return "Profesora Areli";
        }
        else
        {
            return "Profesor Ulyses";
        }

    }
    /// <summary>
    /// Este método es el encargado de identificar cuál personaje es un bot o un jugador, dependiendo del nombre enviado por argumento
    /// </summary>
    /// <param name="nombre"> Nombre del personaje</param>
    /// <returns>Regresa un string con " (BOT)" o " (Tú)"</returns>
    string jugador_o_bot(string nombre)
    {

        return nombre.Contains("_carE") ? " (BOT)" : " (TÚ)";
    }

    public void Return()
    {
        SceneManager.LoadScene("Seleccion_Mapa");//Esta funcion hace que la escena seleccionada se cargue
    }
}
