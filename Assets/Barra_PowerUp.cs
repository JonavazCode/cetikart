using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;


public class Barra_PowerUp : MonoBehaviour
{
    public Propiedades cargasDeJugador;
    //FACIL
    public Sprite facil_cargas_0;
    public Sprite facil_cargas_1;
    public Sprite facil_cargas_2;
    //MEDIO
    public Sprite medio_cargas_0;
    public Sprite medio_cargas_1;
    public Sprite medio_cargas_2;
    public Sprite medio_cargas_3;
    //DIFICIL
    public Sprite dificil_cargas_0;
    public Sprite dificil_cargas_1;
    public Sprite dificil_cargas_2;
    public Sprite dificil_cargas_3;
    public Sprite dificil_cargas_4;
    //SELECCIÓN DE DIFICULTAD
    public Dificultad nivl_dif;
    //Activar animación de PowerUp
    public KartController KC;
    public EnemyPath EP;
    public PanelManager panel;
    //POWER UPS
    public CheckpointsPerPJ cppj;
   



    // Start is called before the first frame update
    void Start()
    {
        
        cppj = FindObjectOfType<CheckpointsPerPJ>();
        panel = FindObjectOfType<PanelManager>();
        KC = FindObjectOfType<KartController>();
        cargasDeJugador = FindObjectOfType<Propiedades>();
        nivl_dif = FindObjectOfType<Dificultad>();
        EP = FindObjectOfType<EnemyPath>();
    }

    // Update is called once per frame
    void Update()
    {
        //NIVEL FACIL
        if (nivl_dif.nivel_dificultad == 1)
        {
            if (cargasDeJugador.cargas == 0)
            {
                this.gameObject.GetComponent<Image>().sprite = facil_cargas_0;
            }

            if (cargasDeJugador.cargas == 1)
            {
                this.gameObject.GetComponent<Image>().sprite = facil_cargas_1;
            }

            if (cargasDeJugador.cargas == 2)
            {
                this.gameObject.GetComponent<Image>().sprite = facil_cargas_2;
            }

            if (CrossPlatformInputManager.GetButton("PowerUp") && cargasDeJugador.cargas == 2)
            {
                KC.animacion.SetTrigger("PowerUp");
                StartCoroutine(PowerUpMolina());
                StartCoroutine(PowerUpIsamel());
                StartCoroutine(PowerUpSergio());
                StartCoroutine(PowerUpUlyses());
                PowerUpAreli();
                StartCoroutine(PowerUpRene());
                StartCoroutine(PowerUpSusana());
                StartCoroutine(PowerUpNino());
                cargasDeJugador.cargas = 0;
            }

        }
        //NIVEL MEDIO
        if (nivl_dif.nivel_dificultad == 2)
        {
            if (cargasDeJugador.cargas == 0)
            {
                this.gameObject.GetComponent<Image>().sprite = medio_cargas_0;
            }

            if (cargasDeJugador.cargas == 1)
            {
                this.gameObject.GetComponent<Image>().sprite = medio_cargas_1;
            }

            if (cargasDeJugador.cargas == 2)
            {
                this.gameObject.GetComponent<Image>().sprite = medio_cargas_2;
            }

            if (cargasDeJugador.cargas == 3)
            {
                this.gameObject.GetComponent<Image>().sprite = medio_cargas_3;
            }
            if (CrossPlatformInputManager.GetButton("PowerUp") && cargasDeJugador.cargas == 3)
            {
                KC.animacion.SetTrigger("PowerUp");
                StartCoroutine(PowerUpIsamel());
                StartCoroutine(PowerUpSergio());
                StartCoroutine(PowerUpUlyses());
                PowerUpAreli();
                StartCoroutine(PowerUpMolina());
                StartCoroutine(PowerUpRene());
                StartCoroutine(PowerUpSusana());
                StartCoroutine(PowerUpNino());
                cargasDeJugador.cargas = 0;
            }
        }
        //NIVEL DIFICIL
        if (nivl_dif.nivel_dificultad == 3)
        {
            if (cargasDeJugador.cargas == 0)
            {
                this.gameObject.GetComponent<Image>().sprite = dificil_cargas_0;
            }

            if (cargasDeJugador.cargas == 1)
            {
                this.gameObject.GetComponent<Image>().sprite = dificil_cargas_1;
            }

            if (cargasDeJugador.cargas == 2)
            {
                this.gameObject.GetComponent<Image>().sprite = dificil_cargas_2;
            }

            if (cargasDeJugador.cargas == 3)
            {
                this.gameObject.GetComponent<Image>().sprite = dificil_cargas_3;
            }

            if (cargasDeJugador.cargas == 4)
            {
                this.gameObject.GetComponent<Image>().sprite = dificil_cargas_4;
            }

            if (CrossPlatformInputManager.GetButton("PowerUp") && cargasDeJugador.cargas == 4)
            {
                KC.animacion.SetTrigger("PowerUp");
                StartCoroutine(PowerUpIsamel());
                StartCoroutine(PowerUpSergio());
                StartCoroutine(PowerUpUlyses());
                PowerUpAreli();
                StartCoroutine(PowerUpMolina());
                StartCoroutine(PowerUpRene());
                StartCoroutine(PowerUpSusana());
                StartCoroutine(PowerUpNino());
                cargasDeJugador.cargas = 0;
            }

        }
    }

    public IEnumerator PowerUpIsamel()
    {
        
        if (KC.nombre.Contains("coco"))
        {
            KC.speed = 1800f;
            yield return new WaitForSeconds(2);
            KC.speed = KC.speedPERdif;
        }
    }

    public IEnumerator PowerUpSergio()
    {
        
        if (KC.nombre.Contains("sergio"))
        {
            KC.speed = 2000f;
            yield return new WaitForSeconds(3);
            KC.speed = KC.speedPERdif;
        }
    }

    public IEnumerator PowerUpUlyses()
    {
        
        if (KC.nombre.Contains("ulyses"))
        {
            var TodoslosBots = GameObject.FindGameObjectsWithTag("Enemy");
            foreach(GameObject bot in TodoslosBots)
            {
                bot.GetComponent<EnemyPath>().speed = 200f; 
            }
            yield return new WaitForSeconds(3);
            foreach (GameObject bot in TodoslosBots)
            {
                bot.GetComponent<EnemyPath>().speed = EP.speedPERdif;
            }
            
        }
    }

    public void PowerUpAreli()
    {

        if (KC.nombre.Contains("areli"))
        {
            panel.AbrirPanel(); 

        }
    }
    public IEnumerator PowerUpMolina()
    {
        if (KC.nombre.Contains("molina"))
        {
            var TodoslosBots = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject bot in TodoslosBots)
            {
                bot.GetComponent<EnemyPath>().speed = 200f;
            }
            var Molina = GameObject.FindGameObjectWithTag("Player");
            Molina.transform.localScale = new Vector3(Molina.transform.localScale.x * 2f, Molina.transform.localScale.y * 2f, Molina.transform.localScale.z * 2f);
            yield return new WaitForSeconds(5);
            Molina.transform.localScale = new Vector3(Molina.transform.localScale.x / 2f, Molina.transform.localScale.y / 2f, Molina.transform.localScale.z / 2f);
            foreach (GameObject bot in TodoslosBots)
            {
                bot.GetComponent<EnemyPath>().speed = EP.speedPERdif;
            }
        }
    }

    public IEnumerator PowerUpRene()
    {
        if (KC.nombre.Contains("agentek"))
        {
            var afectado = GameObject.Find(cppj.uno);
            Debug.LogFormat("afectado por rene: {0}", afectado.name);
            afectado.GetComponent<EnemyPath>().speed = 0f;
            yield return new WaitForSeconds(2);
            afectado.GetComponent<EnemyPath>().speed = EP.speedPERdif;
        }
    }

    public IEnumerator PowerUpSusana()
    {
        if (KC.nombre.Contains("gussa"))
        {
            KC.name = "SUSANA";
            //KC.nombre.Replace("gussa_car", "SUSANA");
            KC.speed = 2000f;
            yield return new WaitForSeconds(5);
            KC.speed = KC.speedPERdif;
            //KC.nombre.Replace("SUSANA", "gussa_car");
            KC.name = "gussa_car";
        }
    }

    public IEnumerator PowerUpNino()
    {
        
        if (KC.nombre.Contains("nino"))
        {
            if(cppj.ocho.Contains("nino"))
            {
                Debug.Log("NIÑO VA EN OCTAVO");
            }
            yield return new WaitForSeconds(2);
        }
    }
}
