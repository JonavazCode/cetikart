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
    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    void Start()
    {
        jugadores = new List<string>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string tag = collision.tag;
        string nombre = collision.name;

        if (!jugadores.Contains(nombre))
            jugadores.Add(nombre);

        
        

        if (tag == "Player")
        {
            SceneManager.LoadScene("Historial Ganador");

        }
       
        



    }
}
