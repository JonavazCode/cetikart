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
   

    // Start is called before the first frame update
    void Start()
    {
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
                StartCoroutine(PowerUpIsamel());
                //StartCoroutine(PowerUpSergio());
                //StartCoroutine(PowerUpUlyses());
                StartCoroutine(PowerUpAreli());
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
                //StartCoroutine(PowerUpSergio());
                //StartCoroutine(PowerUpUlyses());
                StartCoroutine(PowerUpAreli());
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
                //StartCoroutine(PowerUpSergio());
                //StartCoroutine(PowerUpUlyses());
                StartCoroutine(PowerUpAreli());
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
            EP.speed = 200f;
            yield return new WaitForSeconds(3);
            EP.speed = EP.speedPERdif;
        }
    }

    public IEnumerator PowerUpAreli()
    {

        if (KC.nombre.Contains("areli"))
        {
            panel.PanelAreli.SetActive(true);
            yield return new WaitForSeconds(5);
            

        }
    }



}
