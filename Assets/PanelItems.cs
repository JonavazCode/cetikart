using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelItems : MonoBehaviour
{
    public GameObject canvas;
    ItemLlantaBoost LlantaBoost;
    ItemLlantaPonchada LlantaPonchada;
    LogoCeti LogoCeti;

    private void Start()
    {
        canvas = gameObject.GetComponent<PoderEspecial>().Canvas;
    }
    public void ActivarObjeto()
    {
        canvas.SetActive(true);
    }

    public void DesactivarObjeto()
    {
        canvas.SetActive(false);
    }

    public void OnLlantaBoostClicked()
    {
        LlantaBoost = new ItemLlantaBoost();
        Debug.Log("Persona que activo: " + gameObject.name);
        LlantaBoost.setAtacante(gameObject.name);
        LlantaBoost.updateVelocidadAtacante(gameObject, 200f);
        StartCoroutine(EsperarSegundos(5f, 1));
        DesactivarObjeto();
    }

    public void OnLLantaPonchadaClicked()
    {
        LlantaPonchada = new ItemLlantaPonchada();
        LlantaPonchada.setAtacante(gameObject.name);
        LlantaPonchada.posicionAtacante = LlantaPonchada.Atacante.PositionInCareer();

        if(LlantaPonchada.posicionAtacante != 1)
        {
            LlantaPonchada.setAfectado(RacingModeGameManager.instance.PosicionCarrera[LlantaPonchada.posicionAtacante - 1]);
            LlantaPonchada.updateVelocidadAtacante(LlantaPonchada.Afectado, -1000f);
            StartCoroutine(EsperarSegundos(5f, 2));
        }
        else
            return;
    }

    public void OnLogoCetiClicked()
    {
        LogoCeti = new LogoCeti();
        LogoCeti.Action(gameObject);
    }
    public IEnumerator EsperarSegundos(float seg, int id)
    {
        yield return new WaitForSeconds(seg);
        switch (id)
        {
            case 1:
                LlantaBoost.updateVelocidadAtacante(gameObject, -200f);
                break;
            case 2:
                LlantaPonchada.updateVelocidadAtacante(LlantaPonchada.Afectado, 1000f);
                break;
        }
    }
}
