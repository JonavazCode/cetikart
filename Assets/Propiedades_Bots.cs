using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propiedades_Bots : MonoBehaviour
{
    public int CargasBots;
    public int cargasPERdificultad = 0;
    public Dificultad niv_dif;
    public EnemyPath EP;
    public KartController KC;
    public CheckpointsPerPJ cppj;
    public PanelManager obj;

    // Start is called before the first frame update
    void Start()
    {
        cppj = FindObjectOfType<CheckpointsPerPJ>();
        niv_dif = FindObjectOfType<Dificultad>();
        obj = FindObjectOfType<PanelManager>();
        if (niv_dif.nivel_dificultad == 1)
        {
            cargasPERdificultad = 2;
        }

        if (niv_dif.nivel_dificultad == 2)
        {
            cargasPERdificultad = 3;
        }

        if (niv_dif.nivel_dificultad == 3)
        {
            cargasPERdificultad = 4;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (niv_dif.nivel_dificultad == 1)
        {
            if (CargasBots == 2)
            {
                EP.animacion.SetTrigger("PowerUp");
                StartCoroutine(PowerUpIsamel());
                StartCoroutine(PowerUpSergio());
                StartCoroutine(PowerUpUlyses());
                StartCoroutine(PowerUpMolina());
                StartCoroutine(PowerUpRene());
                StartCoroutine(PowerUpSusana());
                StartCoroutine(PowerUpNino());
                AreliPowerUp();
                CargasBots = 0;
            }

        }

        if (niv_dif.nivel_dificultad == 2)
        {
            if (CargasBots == 3)
            {
                EP.animacion.SetTrigger("PowerUp");
                StartCoroutine(PowerUpIsamel());
                StartCoroutine(PowerUpSergio());
                StartCoroutine(PowerUpUlyses());
                StartCoroutine(PowerUpMolina());
                StartCoroutine(PowerUpRene());
                StartCoroutine(PowerUpSusana());
                StartCoroutine(PowerUpNino());
                AreliPowerUp();
                CargasBots = 0;
            }

        }

        if (niv_dif.nivel_dificultad == 3)
        {
            if (CargasBots == 4)
            {
                EP.animacion.SetTrigger("PowerUp");
                StartCoroutine(PowerUpIsamel());
                StartCoroutine(PowerUpSergio());
                StartCoroutine(PowerUpUlyses());
                StartCoroutine(PowerUpMolina());
                StartCoroutine(PowerUpRene());
                StartCoroutine(PowerUpSusana());
                StartCoroutine(PowerUpNino());
                AreliPowerUp();
                CargasBots = 0;
            }

        }




    }
    IEnumerator PowerUpIsamel()
    {

        if (EP.nombre.Contains("coco"))
        {
            EP.speed = 1800f;
            yield return new WaitForSeconds(2);
            EP.speed = EP.speedPERdif;
        }
    }

    IEnumerator PowerUpSergio()
    {

        if (EP.nombre.Contains("sergio"))
        {
            EP.speed = 2000f;
            yield return new WaitForSeconds(3);
            EP.speed = EP.speedPERdif;
        }
    }

    IEnumerator PowerUpUlyses()
    {

        if (EP.nombre.Contains("ulyses"))
        {
            var TodoslosPlayers = GameObject.FindGameObjectsWithTag("Player");
            foreach (GameObject bot in TodoslosPlayers)
            {
                bot.GetComponent<KartController>().speed = 200f;
            }
            yield return new WaitForSeconds(3);
            foreach (GameObject bot in TodoslosPlayers)
            {
                bot.GetComponent<KartController>().speed = KC.speedPERdif;
            }

        }
    }

    IEnumerator PowerUpMolina()
    {
        if (EP.nombre.Contains("molina"))
        {
            var TodoslosPlayers = GameObject.FindGameObjectsWithTag("Players");
            foreach (GameObject bot in TodoslosPlayers)
            {
                bot.GetComponent<KartController>().speed = 200f;
            }
            var Molina = GameObject.Find("molina_carE");
            Molina.transform.localScale = new Vector3(Molina.transform.localScale.x * 2f, Molina.transform.localScale.y * 2f, Molina.transform.localScale.z * 2f);
            yield return new WaitForSeconds(5);
            Molina.transform.localScale = new Vector3(Molina.transform.localScale.x / 2f, Molina.transform.localScale.y / 2f, Molina.transform.localScale.z / 2f);
            foreach (GameObject bot in TodoslosPlayers)
            {
                bot.GetComponent<KartController>().speed = KC.speedPERdif;
            }
        }
    }

    IEnumerator PowerUpRene()
    {
        if (EP.nombre.Contains("agentek"))
        {
            var afectado = GameObject.Find(cppj.uno);
            Debug.LogFormat("afectado por rene: {0}", afectado.name);
            afectado.GetComponent<KartController>().speed = 0f;
            yield return new WaitForSeconds(2);
            afectado.GetComponent<KartController>().speed = EP.speedPERdif;
        }
    }

    IEnumerator PowerUpSusana()
    {
        if (EP.nombre.Contains("gussa"))
        {
            EP.name = "SUSANA";
            yield return new WaitForSeconds(5);
            EP.name = "gussa_car";
        }
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

        if (EP.nombre.Contains("nino"))
        {

            if (cppj.ocho.Contains("nino"))
            {
                Debug.LogFormat("afectado por NIÑO: {0}", afectado7.name);
                afectado7.GetComponent<EnemyPath>().speed = 0f;
                yield return new WaitForSeconds(2);
                afectado7.GetComponent<EnemyPath>().speed = EP.speedPERdif;
            }

            if (cppj.siete.Contains("nino"))
            {
                Debug.LogFormat("afectado por NIÑO: {0}", afectado6.name);
                afectado6.GetComponent<EnemyPath>().speed = 0f;
                yield return new WaitForSeconds(2);
                afectado6.GetComponent<EnemyPath>().speed = EP.speedPERdif;
            }

            if (cppj.seis.Contains("nino"))
            {
                Debug.LogFormat("afectado por NIÑO: {0}", afectado5.name);
                afectado5.GetComponent<EnemyPath>().speed = 0f;
                yield return new WaitForSeconds(2);
                afectado5.GetComponent<EnemyPath>().speed = EP.speedPERdif;
            }

            if (cppj.cinco.Contains("nino"))
            {
                Debug.LogFormat("afectado por NIÑO: {0}", afectado4.name);
                afectado4.GetComponent<EnemyPath>().speed = 0f;
                yield return new WaitForSeconds(2);
                afectado4.GetComponent<EnemyPath>().speed = EP.speedPERdif;
            }

            if (cppj.cuatro.Contains("nino"))
            {
                Debug.LogFormat("afectado por NIÑO: {0}", afectado3.name);
                afectado3.GetComponent<EnemyPath>().speed = 0f;
                yield return new WaitForSeconds(2);
                afectado3.GetComponent<EnemyPath>().speed = EP.speedPERdif;
            }

            if (cppj.tres.Contains("nino"))
            {
                Debug.LogFormat("afectado por NIÑO: {0}", afectado2.name);
                afectado2.GetComponent<EnemyPath>().speed = 0f;
                yield return new WaitForSeconds(2);
                afectado2.GetComponent<EnemyPath>().speed = EP.speedPERdif;
            }

            if (cppj.dos.Contains("nino"))
            {
                Debug.LogFormat("afectado por NIÑO: {0}", afectado1.name);
                afectado1.GetComponent<EnemyPath>().speed = 0f;
                yield return new WaitForSeconds(2);
                afectado1.GetComponent<EnemyPath>().speed = EP.speedPERdif;
            }


        }
    }

    public void AreliPowerUp()
    {
        int Numeros = Random.Range(0, 6);
        Instantiate(obj.Objetos[Numeros], transform.position = new Vector3(obj.Areli.transform.position.x + 2, obj.Areli.transform.position.y + 1), Quaternion.identity);
    }
}
