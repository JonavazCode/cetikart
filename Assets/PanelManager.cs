using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public GameObject PanelAreli;
    public GameObject Areli;
    public GameObject[] Objetos;
    
    private void Start()
    {
        
        PanelAreli.SetActive(false);
    }

    public void Sombrero()
    {
        Instantiate(Objetos[5], transform.position = new Vector3(Areli.transform.position.x + 2, Areli.transform.position.y + 1), Quaternion.identity);
        PanelAreli.SetActive(false);
    }

    public void Ceti()
    {
        Instantiate(Objetos[4], transform.position = new Vector3(Areli.transform.position.x + 2, Areli.transform.position.y + 1), Quaternion.identity);
        PanelAreli.SetActive(false);
    }

    public void Flechas()
    {
        
        Instantiate(Objetos[0], transform.position = new Vector3 (Areli.transform.position.x + 2, Areli.transform.position.y + 1), Quaternion.identity);
        PanelAreli.SetActive(false);
    }

    public void LlantaPonchada()
    {
        Instantiate(Objetos[3], transform.position = new Vector3(Areli.transform.position.x + 2, Areli.transform.position.y + 1), Quaternion.identity);
        PanelAreli.SetActive(false);
    }

    public void LlantaBust()
    {
        Instantiate(Objetos[2], transform.position = new Vector3(Areli.transform.position.x + 2, Areli.transform.position.y + 1), Quaternion.identity);
        PanelAreli.SetActive(false);
    }

    public void Cohete()
    {
        Instantiate(Objetos[1], transform.position = new Vector3(Areli.transform.position.x + 2, Areli.transform.position.y + 1), Quaternion.identity);
        PanelAreli.SetActive(false);
    }

    public void AbrirPanel()
    {
        PanelAreli.SetActive(true);
    }

    public void GenerarItem()
    {

    }
}
