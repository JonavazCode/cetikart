using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Historial : MonoBehaviour
{
    public int numero;
    public Text historial;
    private Checkpoint_Meta ganador;
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
            //jugador.Replace("_car", " ");
            jugador.Replace("a","z");
            historial.text += "\n" + numero + "° Lugar: "+ jugador;
            //jugador.Replace("ulyses_carE", "Profesor Ulyses");
        }


    }
}
