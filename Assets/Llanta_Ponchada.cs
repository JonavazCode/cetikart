using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llanta_Ponchada : MonoBehaviour
{
    public GameObject trash;
    public CheckpointsPerPJ cppj;

    void Start()
    {
        trash = GameObject.Find("Trash");
        cppj = FindObjectOfType<CheckpointsPerPJ>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision.name);
        StartCoroutine(RegresarPosicion(collision.name));

    }
    IEnumerator RegresarPosicion(string nombre_jugador)
    {
        gameObject.transform.position = trash.transform.position;

        int posicion = posicion_jugador(nombre_jugador);
        string nombre_sig_jugador = siguienteJugador(posicion);
       // Debug.Log(posicion);
        //Debug.Log(nombre_sig_jugador);
        yield return new WaitForSeconds(3);
        if (nombre_sig_jugador != "uno")
        {
            var sig_jugador = GameObject.Find(nombre_sig_jugador);
            try
            {
                sig_jugador.GetComponent<EnemyPath>().speed = 1000;
            }
            catch
            {
                sig_jugador.GetComponent<KartController>().speed = 1000;
            }
        }

        Destroy(gameObject);
    }

    int posicion_jugador(string nombre_jugador)
    {
        if (cppj.uno == nombre_jugador)
        {
            return 1;
        }
        else if (cppj.dos == nombre_jugador)
        {
            return 2;
        }
        else if (cppj.tres == nombre_jugador)
        {
            return 3;
        }
        else if (cppj.cuatro == nombre_jugador)
        {
            return 4;
        }
        else if (cppj.cinco == nombre_jugador)
        {
            return 5;
        }
        else if (cppj.seis == nombre_jugador)
        {
            return 6;
        }
        else if (cppj.siete == nombre_jugador)
        {
            return 7;
        }
        else
        {
            return 8;
        }       
    }

    string siguienteJugador(int posicion)
    {
        if (posicion == 8)
        {
            var jugador_siguiente = GameObject.Find(cppj.siete);
            try
            {
                jugador_siguiente.GetComponent<EnemyPath>().speed = 0;
                return jugador_siguiente.name;
            }
            catch
            {
                jugador_siguiente.GetComponent<KartController>().speed = 0;
                return jugador_siguiente.name;
            }
        }
        else if (posicion == 7)
        {
            var jugador_siguiente = GameObject.Find(cppj.seis);
            try
            {
                jugador_siguiente.GetComponent<EnemyPath>().speed = 0;
                return jugador_siguiente.name;
            }
            catch
            {
                jugador_siguiente.GetComponent<KartController>().speed = 0;
                return jugador_siguiente.name;
            }
        }
        else if (posicion == 6)
        {
            var jugador_siguiente = GameObject.Find(cppj.cinco);
            try
            {
                jugador_siguiente.GetComponent<EnemyPath>().speed = 0;
                return jugador_siguiente.name;
            }
            catch
            {
                jugador_siguiente.GetComponent<KartController>().speed = 0;
                return jugador_siguiente.name;
            }
        }
        else if (posicion == 5)
        {
            var jugador_siguiente = GameObject.Find(cppj.cuatro);
            try
            {
                jugador_siguiente.GetComponent<EnemyPath>().speed = 0;
                return jugador_siguiente.name;
            }
            catch
            {
                jugador_siguiente.GetComponent<KartController>().speed = 0;
                return jugador_siguiente.name;
            }
        }
        else if (posicion == 4)
        {
            var jugador_siguiente = GameObject.Find(cppj.tres);
            try
            {
                jugador_siguiente.GetComponent<EnemyPath>().speed = 0;
                return jugador_siguiente.name;
            }
            catch
            {
                jugador_siguiente.GetComponent<KartController>().speed = 0;
                return jugador_siguiente.name;
            }
        }
        else if (posicion == 3)
        {
            var jugador_siguiente = GameObject.Find(cppj.dos);
            try
            {
                jugador_siguiente.GetComponent<EnemyPath>().speed = 0;
                return jugador_siguiente.name;
            }
            catch
            {
                jugador_siguiente.GetComponent<KartController>().speed = 0;
                return jugador_siguiente.name;
            }
        }
        else if (posicion == 2)
        {
            var jugador_siguiente = GameObject.Find(cppj.uno);
            try
            {
                jugador_siguiente.GetComponent<EnemyPath>().speed = 0;
                return jugador_siguiente.name;
            }
            catch
            {
                jugador_siguiente.GetComponent<KartController>().speed = 0;
                return jugador_siguiente.name;
            }
        }
        else
        {
            return "uno";
        }
    }
}
