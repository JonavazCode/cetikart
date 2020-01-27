using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public KartController KC;
    private void Start()
    {
        KC = FindObjectOfType<KartController>();
    }

    public void Sombrero()
    {
        KC.PanelAreli.SetActive(false);
    }

    public void Ceti()
    {
        KC.PanelAreli.SetActive(false);
    }

    public void Flechas()
    {
        KC.PanelAreli.SetActive(false);
    }

    public void LlantaPonchada()
    {
        KC.PanelAreli.SetActive(false);
    }

    public void LlantaBust()
    {
        KC.PanelAreli.SetActive(false);
    }

    public void Cohete()
    {
        KC.PanelAreli.SetActive(false);
    }


}
