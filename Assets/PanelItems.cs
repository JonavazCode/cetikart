using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelItems : MonoBehaviour
{
    public GameObject canvas;
    ItemLlantaBoost LlantaBoost;
    ItemLlantaPonchada LlantaPonchada;
    LogoCeti LogoCeti;
    ItemFlechas ItemFlechas;
    ItemSombrero IS;

    Vector3 pos_temp_Atacante, pos_temp_Afectado;

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
        if (LlantaPonchada.posicionAtacante != 1)
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

    public void OnItemFlechasClicked()
    {
        ItemFlechas = new ItemFlechas();
        ItemFlechas.setAtacante(gameObject.name);
        ItemFlechas.posicionAtacante = ItemFlechas.Atacante.PositionInCareer();
        pos_temp_Atacante = new Vector3(ItemFlechas.Atacante.transform.position.x, ItemFlechas.Atacante.transform.position.y);

        if (ItemFlechas.posicionAtacante != 1)
        {
            ItemFlechas.setAfectado(RacingModeGameManager.instance.PosicionCarrera[ItemFlechas.posicionAtacante - 1]);
            pos_temp_Afectado = new Vector3(ItemFlechas.Afectado.transform.position.x, ItemFlechas.transform.position.y);
            ItemFlechas.MoverPj(ItemFlechas.Atacante, pos_temp_Afectado);
            ItemFlechas.MoverPj(ItemFlechas.Afectado, pos_temp_Atacante);
        }
    }

    public void OnItemSombreroClicked()
    {
        IS = new ItemSombrero();
        IS.setAtacante(gameObject.name);
        IS.posicionAtacante = IS.Atacante.PositionInCareer();
        if (IS.posicionAtacante != 1)
        {
            IS.setAfectado(RacingModeGameManager.instance.PosicionCarrera[1]);
            IS.CambiarEscala(IS.Afectado, 0.5f);
            IS.updateVelocidadAtacante(IS.Afectado, -600f);
            StartCoroutine(EsperarSegundos(5f, 3));
        }
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
            case 3:
                IS.CambiarEscala(IS.Afectado, 2f);
                IS.updateVelocidadAtacante(IS.Afectado, 600f);
                break;
        }
    }
}
