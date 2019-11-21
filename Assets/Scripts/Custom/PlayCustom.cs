using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayCustom : MonoBehaviour
{
    private CambiarOpcion ValoresPJCustom;
    public void Start()
    {
        ValoresPJCustom = FindObjectOfType<CambiarOpcion>();
    }
    public void SceneTransition()
    {
        SceneManager.LoadScene("Seleccion_Mapa");
        PlayerPrefs.SetInt("cabeza", ValoresPJCustom.OpcionCabeza);
        PlayerPrefs.SetInt("torso", ValoresPJCustom.OpcionTorso);
        PlayerPrefs.SetInt("piernas", ValoresPJCustom.OpcionPiernas);
        PlayerPrefs.SetInt("pies", ValoresPJCustom.OpcionPies);
        PlayerPrefs.SetInt("carro", ValoresPJCustom.OpcionCarro);
    }
}
