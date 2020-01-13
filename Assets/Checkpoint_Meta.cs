using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Con esta libreria es posiible controlar el cambio entre scenas dentro del juego
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class Checkpoint_Meta : MonoBehaviour
{
    public List<string> jugadores;
    public CheckpointsPerPJ cppj;
    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    void Start()
    {
        jugadores = new List<string>();
        cppj = FindObjectOfType<CheckpointsPerPJ>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string tag = collision.tag;
       /* string nombre = collision.name;

        if (!jugadores.Contains(nombre))
            jugadores.Add(nombre);
       */
        
        

        if (tag == "Player")
        {
            cppj.carreraFinalizada = !cppj.carreraFinalizada;
            jugadores.Add(cppj.uno);
            jugadores.Add(cppj.dos);
            jugadores.Add(cppj.tres);
            jugadores.Add(cppj.cuatro);
            jugadores.Add(cppj.cinco);
            jugadores.Add(cppj.seis);
            jugadores.Add(cppj.siete);
            jugadores.Add(cppj.ocho);
            SceneManager.LoadScene("Historial Ganador");

        }
       
        



    }
}
