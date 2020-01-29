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
    // Start is called before the first frame update
    void Start()
    {
        niv_dif = FindObjectOfType<Dificultad>();
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
                CargasBots = 0;
            }
        
        }

        if (niv_dif.nivel_dificultad == 2)
        {
            if (CargasBots == 3)
            {
                EP.animacion.SetTrigger("PowerUp");
                CargasBots = 0;
            }

        }

        if (niv_dif.nivel_dificultad == 3)
        {
            if (CargasBots == 4)
            {
                EP.animacion.SetTrigger("PowerUp");
                CargasBots = 0;
            }

        }

        IEnumerator PowerUpIsamel()
        {

            if (EP.nombre.Contains("coco"))
            {
                KC.speed = 1800f;
                yield return new WaitForSeconds(2);
                KC.speed = KC.speedPERdif;
            }
        }
    }
}
