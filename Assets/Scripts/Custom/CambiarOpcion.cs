using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambiarOpcion : MonoBehaviour
{
    public GameObject panel_1, panel_2, panel_3, panel_4, panel_5;
    public SpriteRenderer Cabeza,Torso,Piernas,Pies,Carro;
    public Image CabezaOpcion, TorsoOpcion, PiernasOpcion, PiesOpcion, CarroOpcion;

    public Sprite Cabeza_0, Cabeza_1, Cabeza_2, Cabeza_3, Cabeza_4;
    public Sprite Torso_0, Torso_1, Torso_2, Torso_3, Torso_4;
    public Sprite Piernas_0, Piernas_1, Piernas_2, Piernas_3, Piernas_4;
    public Sprite Pies_0, Pies_1, Pies_2, Pies_3, Pies_4;
    public Sprite Carro_0, Carro_1, Carro_2, Carro_3, Carro_4;


    public int OpcionCabeza;
    public int OpcionTorso;
    public int OpcionPiernas;
    public int OpcionPies;
    public int OpcionCarro;

    private void Awake()
    {
        OpcionCabeza = PlayerPrefs.GetInt("cabeza", 0);
        OpcionTorso = PlayerPrefs.GetInt("torso", 0);
        OpcionPiernas = PlayerPrefs.GetInt("piernas", 0);
        OpcionPies = PlayerPrefs.GetInt("pies", 0);
        OpcionCarro = PlayerPrefs.GetInt("carro", 0);
    }

    void Update()
    {
        // CABEZA ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        CabezaOpcion.sprite = Cabeza.sprite;

        if (OpcionCabeza == 0)
        {
            Cabeza.sprite = Cabeza_0;

        }
        else if (OpcionCabeza == 1)
        {
            Cabeza.sprite = Cabeza_1;

        }
        else if (OpcionCabeza == 2) {

            Cabeza.sprite = Cabeza_2;
        }
        else if (OpcionCabeza == 3)
        {
            Cabeza.sprite = Cabeza_3;

        }
        else if (OpcionCabeza == 4)
        {
            Cabeza.sprite = Cabeza_4;

        }
        
        // TORSO ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
       TorsoOpcion.sprite = Torso.sprite;

        if (OpcionTorso == 0)
        {
            Torso.sprite = Torso_0;

        }
        else if (OpcionTorso == 1)
        {
            Torso.sprite = Torso_1;

        }
        else if (OpcionTorso == 2)
        {

            Torso.sprite = Torso_2;
        }
        else if (OpcionTorso == 3)
        {
            Torso.sprite = Torso_3;

        }
        else if (OpcionTorso == 4)
        {
            Torso.sprite = Torso_4;

        }
        // PIERNAS ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        PiernasOpcion.sprite = Piernas.sprite;

        if (OpcionPiernas == 0)
        {
            Piernas.sprite = Piernas_0;

        }
        else if (OpcionPiernas == 1)
        {
            Piernas.sprite = Piernas_1;

        }
        else if (OpcionPiernas == 2)
        {

            Piernas.sprite = Piernas_2;
        }
        else if (OpcionPiernas == 3)
        {
            Piernas.sprite = Piernas_3;

        }
        else if (OpcionPiernas == 4)
        {
            Piernas.sprite = Piernas_4;

        }
        // PIERNAS ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        PiesOpcion.sprite = Pies.sprite;

        if (OpcionPies == 0)
        {
            Pies.sprite = Pies_0;

        }
        else if (OpcionPies == 1)
        {
            Pies.sprite = Pies_1;

        }
        else if (OpcionPies == 2)
        {

            Pies.sprite = Pies_2;
        }
        else if (OpcionPies == 3)
        {
            Pies.sprite = Pies_3;

        }
        else if (OpcionPies == 4)
        {
            Pies.sprite = Pies_4;

        }
        // CARRO ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        CarroOpcion.sprite = Carro.sprite;

        if (OpcionCarro == 0)
        {
            Carro.sprite = Carro_0;

        }
        else if (OpcionCarro == 1)
        {
            Carro.sprite = Carro_1;

        }
        else if (OpcionCarro == 2)
        {

            Carro.sprite = Carro_2;
        }
        else if (OpcionCarro == 3)
        {
            Carro.sprite = Carro_3;

        }
        else if (OpcionCarro == 4)
        {
            Carro.sprite = Carro_4;

        }

    }
    ////////////////////////////////////////////////////////////// PANELES  ///////////////////////////////////////////////////////////////////////////////////////////////////
    public void OpenPanel_1() {


        panel_1.SetActive(true);
        ClosePanel_2();
        ClosePanel_3();
        ClosePanel_4();
        ClosePanel_5();
    }

    public void ClosePanel_1()
    {


        panel_1.SetActive(false);
    }


    public void OpenPanel_2()
    {


        panel_2.SetActive(true);
        ClosePanel_1();

        ClosePanel_3();
        ClosePanel_4();
        ClosePanel_5();
    }

    public void ClosePanel_2()
    {


        panel_2.SetActive(false);
    }


    public void OpenPanel_3()
    {


        panel_3.SetActive(true);
        ClosePanel_1();
        ClosePanel_2();

        ClosePanel_4();
        ClosePanel_5();
    }

    public void ClosePanel_3()
    {


        panel_3.SetActive(false);
    }


    public void OpenPanel_4()
    {


        panel_4.SetActive(true);
        ClosePanel_1();
        ClosePanel_2();
        ClosePanel_3();

        ClosePanel_5();
    }

    public void ClosePanel_4()
    {


        panel_4.SetActive(false);
    }

    public void OpenPanel_5()
    {


        panel_5.SetActive(true);
        ClosePanel_1();
        ClosePanel_2();
        ClosePanel_3();
        ClosePanel_4();
  
    }

    public void ClosePanel_5()
    {


        panel_5.SetActive(false);
    }


    ///////////////////////////////////////////////////////// OPCIONES CABEZA ////////////////////////////////////////////////////////////////////////////////////////////////////////

    public void CambiarCabeza1() {

        OpcionCabeza = 1;
    }

    public void CambiarCabeza2()
    {

        OpcionCabeza = 2;
    }

    public void CambiarCabeza3()
    {

        OpcionCabeza = 3;
    }

    public void CambiarCabeza4()
    {

        OpcionCabeza = 4;
    }


    ///////////////////////////////////////////////////////// OPCIONES TORSO ////////////////////////////////////////////////////////////////////////////////////////////////////////
    public void CambiarTorso1()
    {

        OpcionTorso = 1;
    }

    public void CambiarTorso2()
    {

        OpcionTorso = 2;
    }

    public void CambiarTorso3()
    {

        OpcionTorso = 3;
    }

    public void CambiarTorso4()
    {

        OpcionTorso = 4;
    }
    ///////////////////////////////////////////////////////// OPCIONES PIERNAS ////////////////////////////////////////////////////////////////////////////////////////////////////////
    public void CambiarPiernas1()
    {

        OpcionPiernas = 1;
    }

    public void CambiarPiernas2()
    {

        OpcionPiernas = 2;
    }

    public void CambiarPiernas3()
    {

        OpcionPiernas = 3;
    }

    public void CambiarPiernas4()
    {

        OpcionPiernas = 4;
    }
    ///////////////////////////////////////////////////////// OPCIONES PIES ////////////////////////////////////////////////////////////////////////////////////////////////////////
    public void CambiarPies1()
    {

        OpcionPies = 1;
    }

    public void CambiarPies2()
    {

        OpcionPies = 2;
    }

    public void CambiarPies3()
    {

        OpcionPies = 3;
    }

    public void CambiarPies4()
    {

        OpcionPies = 4;
    }
    ///////////////////////////////////////////////////////// OPCIONES CARRO ////////////////////////////////////////////////////////////////////////////////////////////////////////
    public void CambiarCarro1()
    {

        OpcionCarro = 1;
    }

    public void CambiarCarro2()
    {

        OpcionCarro = 2;
    }

    public void CambiarCarro3()
    {

        OpcionCarro = 3;
    }

    public void CambiarCarro4()
    {

        OpcionCarro = 4;
    }
}
