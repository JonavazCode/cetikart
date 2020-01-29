using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Propiedades_Bots : MonoBehaviour
{
    public int CargasBots;
    public int cargasPERdificultad;
    public Dificultad niv_dif;
    public EnemyPath EP;
    
   

    // Start is called before the first frame update
    void Start()
    {
        
        niv_dif = FindObjectOfType<Dificultad>();
        
        EP = FindObjectOfType<EnemyPath>();
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
          
            if (CargasBots == cargasPERdificultad)
            {
                EP.animacion.SetTrigger("PowerUp");
                CargasBots = 0;
                
            }

        }

        if (niv_dif.nivel_dificultad == 2)
        {
            if (CargasBots == cargasPERdificultad)
            {
                EP.animacion.SetTrigger("PowerUp");
                CargasBots = 0;

            }

        }

        if (niv_dif.nivel_dificultad == 3)
        {
            if (CargasBots == cargasPERdificultad)
            {
                EP.animacion.SetTrigger("PowerUp");
                CargasBots = 0;

            }

        }




    }
  


}
