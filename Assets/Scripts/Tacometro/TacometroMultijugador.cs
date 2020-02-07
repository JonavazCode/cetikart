using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TacometroMultijugador : MonoBehaviour
{

    public Rigidbody2D _rigidbody;
    public Transform punteroEjeZ;

    private float factorDeAngulo = -8.5f;
    private Vector3 AnguloEulerInicial;
    private float velocidadJugador;
    private void Start()
    {
        StartCoroutine(Esperar1s());
        AnguloEulerInicial = punteroEjeZ.transform.localEulerAngles;
    }

    private void Update()
    {
        velocidadJugador = _rigidbody.velocity.magnitude * 3.6f;
        punteroEjeZ.transform.localEulerAngles = new Vector3(AnguloEulerInicial.x, AnguloEulerInicial.y, AnguloEulerInicial.z + velocidadJugador * factorDeAngulo);
    }

    private IEnumerator Esperar1s()
    {
        yield return new WaitForSeconds(1);
    }
}
