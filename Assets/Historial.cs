using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Historial : MonoBehaviour
{
    public int numero;
    public Text historial;
    private Checkpoint_Meta ganador;
    public int selec_profesor;
    // Start is called before the first frame update
    void Start()
    {
        ganador = FindObjectOfType<Checkpoint_Meta>();
        MostrarJugadores();
    }

    // Update is called once per frame
    void Update()
    {
        
            
        
    }

    void MostrarJugadores()
    {
        foreach (string jugador in ganador.jugadores)
        {
            Debug.Log(jugador);
            numero++;
          
            historial.text += jugador.Contains("molina_car") ? "\n" + numero + "° Lugar: " + "Profesor Molina" : "";
            historial.text += jugador.Contains("ulyses_car") ? "\n" + numero + "° Lugar: " + "Profesor Ulyses" : "";
            historial.text += jugador.Contains("nino_car") ? "\n" + numero + "° Lugar: " + "Profesor Niño" : "";
            historial.text += jugador.Contains("areli_car") ? "\n" + numero + "° Lugar: " + "Profesora Areli" : "";
            historial.text += jugador.Contains("sergio_car") ? "\n" + numero + "° Lugar: " + "Profesor Sergio" : "";
            historial.text += jugador.Contains("coco_car") ? "\n" + numero + "° Lugar: " + "Profesor Ismael" : "";
            historial.text += jugador.Contains("gussa_car") ? "\n" + numero + "° Lugar: " + "Profesora Susana" : "";
            historial.text += jugador.Contains("agentek_car") ? "\n" + numero + "° Lugar: " + "Profesor Luis Rene" : "";


            //historial.text += "\n" + numero + "° Lugar: "+ jugador.Replace("_car","");

        }


    }
}
