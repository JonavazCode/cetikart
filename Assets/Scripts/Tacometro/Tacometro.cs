using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tacometro : MonoBehaviour
{
    #region referenciasGameObjects
    public GameObject controles;
    public GameObject tacometro;
    public GameObject punteroGO;
    #endregion
    public KartController jugador;


    public Transform punteroEjeZ;
    public float factorDeAngulo = -8.5f;

    public Vector3 AnguloEulerInicial;
    public Rigidbody2D _rigidbody;
    public float velocidadJugador;
    private void Awake()
    {
        controles = GameObject.Find("MobileSingleStickControl");
        tacometro = controles.transform.GetChild(7).gameObject;
        punteroGO = tacometro.transform.GetChild(0).gameObject;
        punteroEjeZ = punteroGO.transform;
        //jugador = FindObjectOfType<KartController>();
        //_rigidbody = jugador.rb;
        AnguloEulerInicial = punteroEjeZ.transform.localEulerAngles;
        
    }

    public void Start()
    {
        jugador = FindObjectOfType<KartController>();
        _rigidbody = jugador.rb;
    }
    private void Update()
    {
        velocidadJugador = _rigidbody.velocity.magnitude * 3.6f;
        punteroEjeZ.transform.localEulerAngles = new Vector3(AnguloEulerInicial.x, AnguloEulerInicial.y, AnguloEulerInicial.z + velocidadJugador * factorDeAngulo);
    }

}
