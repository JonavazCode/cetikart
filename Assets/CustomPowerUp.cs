using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CustomPowerUp : MonoBehaviour
{
    
    public KartController KC;
    public EnemyPath EP;
    public CheckpointsPerPJ cppj;
    public PanelManager panel;
    public Dificultad nivl_dif;
    public Propiedades cargas;
    public bool limitador = false;


    // Start is called before the first frame update
    void Start()
    {
        cppj = FindObjectOfType<CheckpointsPerPJ>();
        KC = FindObjectOfType<KartController>();
        EP = FindObjectOfType<EnemyPath>();
        panel = FindObjectOfType<PanelManager>();
        nivl_dif = FindObjectOfType<Dificultad>();
        cargas = FindObjectOfType<Propiedades>();
    }

    // Update is called once per frame
    void Update()
    {
        if (nivl_dif.nivel_dificultad == 1)
        {
            int Numeros = Random.Range(0, 9);
            if (Numeros == 0 && CrossPlatformInputManager.GetButton("PowerUp") && cargas.cargasPERdificultad == 2 && !limitador)
            {
               
                StartCoroutine(PowerUpIsamel());
                Debug.Log("POWER UP COCO");
                cargas.cargas = 0;
            }

            if (Numeros == 1 && CrossPlatformInputManager.GetButton("PowerUp") && cargas.cargasPERdificultad == 2 && !limitador)
            {
                StartCoroutine(PowerUpSergio());
                Debug.Log("POWER UP SERGIO");
                cargas.cargas = 0;
            }

            if (Numeros == 2 && CrossPlatformInputManager.GetButton("PowerUp") && cargas.cargasPERdificultad == 2 && !limitador)
            {
                StartCoroutine(PowerUpUlyses());
                Debug.Log("POWER UP ULYSES");
                cargas.cargas = 0;
            }

            if (Numeros == 3 && CrossPlatformInputManager.GetButton("PowerUp") && cargas.cargasPERdificultad == 2 && !limitador)
            {
                StartCoroutine(PowerUpMolina());
                Debug.Log("POWER UP MOLINA");
                cargas.cargas = 0;
            }

            if (Numeros == 4 && CrossPlatformInputManager.GetButton("PowerUp") && cargas.cargasPERdificultad == 2 && !limitador)
            {
                StartCoroutine(PowerUpRene());
                Debug.Log("POWER UP RENE");
                cargas.cargas = 0;
            }

            if (Numeros == 5 && CrossPlatformInputManager.GetButton("PowerUp") && cargas.cargasPERdificultad == 2 && !limitador)
            {
                StartCoroutine(PowerUpSusana());
                Debug.Log("POWER UP SUSANA");
                cargas.cargas = 0;
            }

            if (Numeros == 6 && CrossPlatformInputManager.GetButton("PowerUp") && cargas.cargasPERdificultad == 2 && !limitador)
            {
                StartCoroutine(PowerUpNino());
                Debug.Log("POWER UP NINO");
                cargas.cargas = 0;
            }

            if (Numeros == 7 && CrossPlatformInputManager.GetButton("PowerUp") && cargas.cargasPERdificultad == 2 && !limitador)
            {
                PowerUpAreli();
                Debug.Log("POWER UP ARELI");
                cargas.cargas = 0;
            }
        }

        if (nivl_dif.nivel_dificultad == 2)
        {
            int Numeros = Random.Range(0, 9);
            if (Numeros == 0 && CrossPlatformInputManager.GetButton("PowerUp") && cargas.cargasPERdificultad == 3 && !limitador)
            {
                StartCoroutine(PowerUpIsamel());
                Debug.Log("POWER UP COCO");
                cargas.cargas = 0;
            }

            if (Numeros == 1 && CrossPlatformInputManager.GetButton("PowerUp") && cargas.cargasPERdificultad == 3 && !limitador)
            {
                StartCoroutine(PowerUpSergio());
                Debug.Log("POWER UP SERGIO");
                cargas.cargas = 0;
            }

            if (Numeros == 2 && CrossPlatformInputManager.GetButton("PowerUp") && cargas.cargasPERdificultad == 3 && !limitador)
            {
                StartCoroutine(PowerUpUlyses());
                Debug.Log("POWER UP ULYSES");
                cargas.cargas = 0;
            }

            if (Numeros == 3 && CrossPlatformInputManager.GetButton("PowerUp") && cargas.cargasPERdificultad == 3 && !limitador)
            {
                StartCoroutine(PowerUpMolina());
                Debug.Log("POWER UP MOLINA");
                cargas.cargas = 0;
            }

            if (Numeros == 4 && CrossPlatformInputManager.GetButton("PowerUp") && cargas.cargasPERdificultad == 3 && !limitador)
            {
                StartCoroutine(PowerUpRene());
                Debug.Log("POWER UP RENE");
                cargas.cargas = 0;
            }

            if (Numeros == 5 && CrossPlatformInputManager.GetButton("PowerUp") && cargas.cargasPERdificultad == 3 && !limitador)
            {
                StartCoroutine(PowerUpSusana());
                Debug.Log("POWER UP SUSANA");
                cargas.cargas = 0;
            }

            if (Numeros == 6 && CrossPlatformInputManager.GetButton("PowerUp") && cargas.cargasPERdificultad == 3 && !limitador)
            {
                StartCoroutine(PowerUpNino());
                Debug.Log("POWER UP NINO");
                cargas.cargas = 0;
            }

            if (Numeros == 7 && CrossPlatformInputManager.GetButton("PowerUp") && cargas.cargasPERdificultad == 3 && !limitador)
            {
                PowerUpAreli();
                Debug.Log("POWER UP ARELI");
                cargas.cargas = 0;
            }

        }

        if (nivl_dif.nivel_dificultad == 3)
        {
            int Numeros = Random.Range(0, 9);
            if (Numeros == 0 && CrossPlatformInputManager.GetButton("PowerUp") && cargas.cargasPERdificultad == 4 && !limitador)
            {
                StartCoroutine(PowerUpIsamel());
                Debug.Log("POWER UP COCO");
                cargas.cargas = 0;
            }

            if (Numeros == 1 && CrossPlatformInputManager.GetButton("PowerUp") && cargas.cargasPERdificultad == 4 && !limitador)
            {
                StartCoroutine(PowerUpSergio());
                Debug.Log("POWER UP SERGIO");
                cargas.cargas = 0;
            }

            if (Numeros == 2 && CrossPlatformInputManager.GetButton("PowerUp") && cargas.cargasPERdificultad == 4 && !limitador)
            {
                StartCoroutine(PowerUpUlyses());
                Debug.Log("POWER UP ULYSES");
                cargas.cargas = 0;
            }

            if (Numeros == 3 && CrossPlatformInputManager.GetButton("PowerUp") && cargas.cargasPERdificultad == 4 && !limitador)
            {
                StartCoroutine(PowerUpMolina());
                Debug.Log("POWER UP MOLINA");
                cargas.cargas = 0;
            }

            if (Numeros == 4 && CrossPlatformInputManager.GetButton("PowerUp") && cargas.cargasPERdificultad == 4 && !limitador)
            {
                StartCoroutine(PowerUpRene());
                Debug.Log("POWER UP RENE");
                cargas.cargas = 0;
            }

            if (Numeros == 5 && CrossPlatformInputManager.GetButton("PowerUp") && cargas.cargasPERdificultad == 4 && !limitador)
            {
                StartCoroutine(PowerUpSusana());
                Debug.Log("POWER UP SUSANA");
                cargas.cargas = 0;
            }

            if (Numeros == 6 && CrossPlatformInputManager.GetButton("PowerUp") && cargas.cargasPERdificultad == 4 && !limitador)
            {
                StartCoroutine(PowerUpNino());
                Debug.Log("POWER UP NINO");
                cargas.cargas = 0;
            }

            if (Numeros == 7 && CrossPlatformInputManager.GetButton("PowerUp") && cargas.cargasPERdificultad == 4 && !limitador)
            {
                PowerUpAreli();
                Debug.Log("POWER UP ARELI");
                cargas.cargas = 0;
                
            }

        }

    }

    public IEnumerator PowerUpIsamel()
    {
            limitador = true;
            KC.speed = 1800f;
            yield return new WaitForSeconds(2);
            KC.speed = KC.speedPERdif;
        limitador = false;
    }

    public IEnumerator PowerUpSergio()
    {
            limitador = true;
            KC.speed = 2000f;
            yield return new WaitForSeconds(3);
            KC.speed = KC.speedPERdif;
        limitador = false;
    }

    public IEnumerator PowerUpUlyses()
    {
        limitador = true;
        var TodoslosBots = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject bot in TodoslosBots)
            {
                bot.GetComponent<EnemyPath>().speed = 200f;
            }
            yield return new WaitForSeconds(3);
            foreach (GameObject bot in TodoslosBots)
            {
                bot.GetComponent<EnemyPath>().speed = EP.speedPERdif;
            }
        limitador = false;

    }

    public IEnumerator PowerUpMolina()
    {
        limitador = true;
        var TodoslosBots = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject bot in TodoslosBots)
            {
                bot.GetComponent<EnemyPath>().speed = 200f;
            }
            var Molina = GameObject.FindGameObjectWithTag("Player");
            Molina.transform.localScale = new Vector3(Molina.transform.localScale.x * 2f, Molina.transform.localScale.y * 2f, Molina.transform.localScale.z * 2f);
            yield return new WaitForSeconds(5);
        limitador = false;
        Molina.transform.localScale = new Vector3(Molina.transform.localScale.x / 2f, Molina.transform.localScale.y / 2f, Molina.transform.localScale.z / 2f);
            foreach (GameObject bot in TodoslosBots)
            {
                bot.GetComponent<EnemyPath>().speed = EP.speedPERdif;
            }
        
    }

    public IEnumerator PowerUpRene()
    {
        limitador = true;
        var afectado = GameObject.Find(cppj.uno);
            Debug.LogFormat("afectado por rene: {0}", afectado.name);
            afectado.GetComponent<EnemyPath>().speed = 0f;
            yield return new WaitForSeconds(2);
            afectado.GetComponent<EnemyPath>().speed = EP.speedPERdif;
        limitador = false;
    }

    public IEnumerator PowerUpSusana()
    {
        limitador = true;
        KC.name = "CUSTOM";
            KC.speed = 2000f;
            yield return new WaitForSeconds(5);
            KC.speed = KC.speedPERdif;
            KC.name = "coco_car";
        limitador = false;
    }

    public IEnumerator PowerUpNino()
    {
        
        var afectado7 = GameObject.Find(cppj.siete);
        var afectado6 = GameObject.Find(cppj.seis);
        var afectado5 = GameObject.Find(cppj.cinco);
        var afectado4 = GameObject.Find(cppj.cuatro);
        var afectado3 = GameObject.Find(cppj.tres);
        var afectado2 = GameObject.Find(cppj.dos);
        var afectado1 = GameObject.Find(cppj.uno);

            if (cppj.ocho.Contains("coco"))
            {
            limitador = true;
            Debug.LogFormat("afectado por NIÑO: {0}", afectado7.name);
                afectado7.GetComponent<EnemyPath>().speed = 0f;
                yield return new WaitForSeconds(2);
                afectado7.GetComponent<EnemyPath>().speed = EP.speedPERdif;
                limitador = false;

            }

            if (cppj.siete.Contains("coco"))
            {
            limitador = true;
            Debug.LogFormat("afectado por NIÑO: {0}", afectado6.name);
                afectado6.GetComponent<EnemyPath>().speed = 0f;
                yield return new WaitForSeconds(2);
                afectado6.GetComponent<EnemyPath>().speed = EP.speedPERdif;
            limitador = false;
            }

            if (cppj.seis.Contains("coco"))
            {
            limitador = true;
            Debug.LogFormat("afectado por NIÑO: {0}", afectado5.name);
                afectado5.GetComponent<EnemyPath>().speed = 0f;
                yield return new WaitForSeconds(2);
                afectado5.GetComponent<EnemyPath>().speed = EP.speedPERdif;
            limitador = false;
            }

            if (cppj.cinco.Contains("coco"))
            {
            limitador = true;
            Debug.LogFormat("afectado por NIÑO: {0}", afectado4.name);
                afectado4.GetComponent<EnemyPath>().speed = 0f;
                yield return new WaitForSeconds(2);
                afectado4.GetComponent<EnemyPath>().speed = EP.speedPERdif;
            limitador = false;
            }

            if (cppj.cuatro.Contains("coco"))
            {
            limitador = true;
            Debug.LogFormat("afectado por NIÑO: {0}", afectado3.name);
                afectado3.GetComponent<EnemyPath>().speed = 0f;
                yield return new WaitForSeconds(2);
                afectado3.GetComponent<EnemyPath>().speed = EP.speedPERdif;
            limitador = false;
            }

            if (cppj.tres.Contains("coco"))
            {
            limitador = true;
            Debug.LogFormat("afectado por NIÑO: {0}", afectado2.name);
                afectado2.GetComponent<EnemyPath>().speed = 0f;
                yield return new WaitForSeconds(2);
                afectado2.GetComponent<EnemyPath>().speed = EP.speedPERdif;
            limitador = false;
            }

            if (cppj.dos.Contains("coco"))
            {
            limitador = true;
            Debug.LogFormat("afectado por NIÑO: {0}", afectado1.name);
                afectado1.GetComponent<EnemyPath>().speed = 0f;
                yield return new WaitForSeconds(2);
                afectado1.GetComponent<EnemyPath>().speed = EP.speedPERdif;
            limitador = false;
            }


    }

    public void PowerUpAreli()
    {
        limitador = true;
        panel.PanelAreli.SetActive(true);
        limitador = false;
    }
}
