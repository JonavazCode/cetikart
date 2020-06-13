using JetBrains.Annotations;
using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class PoderEspecial : MonoBehaviourPun
{
    [SerializeField] private bool isMolina;
    [SerializeField] private List<GameObject> Afectados = new List<GameObject>();
    [SerializeField] private PlayerItemInteract pii;

    [SerializeField] private GameObject Afectado;
    [SerializeField] private float VelocidadAfectado;

    public GameObject Canvas;

    private void Start()
    {
        Canvas = GameObject.Find("ItemCanvas");
        Canvas.SetActive(false);
    }
    public void Poderes(string TipoPoder)
    {
        switch (TipoPoder)
        {
            case "molina":
                isMolina = true;
                PoderMolina();
                break;
            case "sergio":
                PoderSergio();
                gameObject.GetComponent<Animator>().SetTrigger("PowerUp");
                break;
            case "ulyses":
                PoderUlyses();
                gameObject.GetComponent<Animator>().SetTrigger("PowerUp");
                break;
            case "gussa":
                PoderSusana();
                gameObject.GetComponent<Animator>().SetTrigger("PowerUp");
                break;
            case "agentek":
                PoderAgentek();
                gameObject.GetComponent<Animator>().SetTrigger("PowerUp");
                break;
            case "coco":
                PoderCoco();
                gameObject.GetComponent<Animator>().SetTrigger("PowerUp");
                break;
            case "nino":
                PoderNino();
                gameObject.GetComponent<Animator>().SetTrigger("PowerUp");
                break;
            case "areli":
                PoderAreli();
                break;
        }
    }
    public void Update()
    {
        if (isMolina)
        {
            pii = gameObject.GetComponent<PlayerItemInteract>();
            //comprobar si adelantó a alguien
            if (pii.arrebasoAAlguien)
            {
                var Afectado = GameObject.Find(RacingModeGameManager.instance.PosicionCarrera[pii.posicion + 1]);
                //si el afectado no está en la lista lo agrega, si ya está no hace nada
                if (!Afectados.Contains(Afectado) && Afectado.GetComponent<PlayerItemInteract>().inmune == false)
                {
                    Debug.Log("Afectado agregado a la lista");
                    Afectados.Add(Afectado);
                    ActualizarVel(-200f, Afectado);
                }       
            }
        }
    }
    public void PoderMolina()
    {
        Debug.Log("Poder uno");
        ActualizarVel(100f, gameObject);
        CambiarTamanio(gameObject, 2f);
        StartCoroutine(TiempoEspera(5f, 1));
    }

    public void PoderSergio()
    {
        Debug.Log("Poder dos");
        ActualizarVel(300f, gameObject);
        StartCoroutine(TiempoEspera(3.5f, 2));
    }

    public void PoderUlyses()
    {
        Debug.Log("Poder tres");
        var Jugadores = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject Jugador in Jugadores)
        {
            //si no es este jugador y el jugador no es inmune
            if (Jugador.name != gameObject.name && Jugador.GetComponent<PlayerItemInteract>().inmune == false)
            {
                Afectados.Add(Jugador);
                ActualizarVel(-200f, Jugador);
            }
        }
        StartCoroutine(TiempoEspera(2.5f, 3));
    }

    public void PoderSusana()
    {
        Debug.Log("Poder cuatro");
        gameObject.GetComponent<PhotonView>().RPC("CambiarInmune", RpcTarget.All, true);
        StartCoroutine(TiempoEspera(5f, 4));
    }

    public void PoderAgentek()
    {
        Debug.Log("Poder cinco");
        Afectado = GameObject.Find(RacingModeGameManager.instance.PosicionCarrera[1]);
        if (Afectado.name != gameObject.name && Afectado.GetComponent<PlayerItemInteract>().inmune == false)
        {
            VelocidadAfectado = Afectado.GetComponent<CarMovement>().speed;
            ActualizarVel(-VelocidadAfectado, Afectado);
        }
        StartCoroutine(TiempoEspera(1.5f, 5));
    }

    public void PoderCoco()
    {
        Debug.Log("Poder seis");
        ActualizarVel(500f, gameObject);
        StartCoroutine(TiempoEspera(5f, 6));
    }

    public void PoderNino()
    {
        Debug.Log("Poder siete");
        pii = gameObject.GetComponent<PlayerItemInteract>();
        if (pii.posicion != 1)
        {
            Afectado = GameObject.Find(RacingModeGameManager.instance.PosicionCarrera[pii.posicion - 1]);
            if (Afectado.GetComponent<PlayerItemInteract>().inmune == false)
            {
                VelocidadAfectado = Afectado.GetComponent<CarMovement>().speed;
                ActualizarVel(-VelocidadAfectado, Afectado);
            }
            else
                Afectado = null;
        }
        StartCoroutine(TiempoEspera(1.5f, 7));

    }

    public void PoderAreli()
    {
        Debug.Log("Poder ocho");
        Canvas.SetActive(true);
    }
    public IEnumerator TiempoEspera(float segundos, int id)
    {
        yield return new WaitForSeconds(segundos);
        switch (id)
        {
            case 1: 
                isMolina = false;
                ActualizarVel(-100f, gameObject);
                CambiarTamanio(gameObject, .5f);
                if (Afectados.Count != 0)
                {
                    foreach (GameObject afectado in Afectados)
                    {
                        Debug.Log("regresar velocidad a " + afectado.name);
                        ActualizarVel(200f, afectado);
                        Afectados.Remove(afectado);
                    }
                }
                break;

            case 2:
                ActualizarVel(-300f, gameObject);
                break;

            case 3:
                if (Afectados.Count != 0)
                {
                    foreach (GameObject afectado in Afectados)
                    {
                        ActualizarVel(200f, afectado);
                        Afectados.Remove(afectado);
                    }
                }
                break;
            case 4:
                gameObject.GetComponent<PhotonView>().RPC("CambiarInmune", RpcTarget.All, false);
                break;
            case 5:
                ActualizarVel(VelocidadAfectado, Afectado);
                break;
            case 6:
                ActualizarVel(-500f, gameObject);
                break;
            case 7:
                if(Afectado != null)
                    ActualizarVel(VelocidadAfectado, Afectado);
                break;
        }
    }

    public void ActualizarVel(float velocidad, GameObject objetivo)
    {
        objetivo.GetComponent<PhotonView>().RPC("ActualizarVelocidad", RpcTarget.All, velocidad);
    }

    public void CambiarTamanio(GameObject objetivo, float multiplicador)
    { 
        objetivo.transform.localScale = new Vector3(objetivo.transform.localScale.x * multiplicador, objetivo.transform.localScale.y * multiplicador, objetivo.transform.localScale.z * multiplicador);
    }
}

