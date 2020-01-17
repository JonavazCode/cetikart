using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cetikart.utilidades;

public class Flechas : MonoBehaviour
{
    public CheckpointsPerPJ cppj;
    void Start()
    {
        cppj = FindObjectOfType<CheckpointsPerPJ>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject atacante = GameObject.Find(collision.name);
        int posicion_atacante = cppj.posicion_carrera_por_nombre(atacante.name);
        if (posicion_atacante != 1)
        {
            GameObject afectado = GameObject.Find(cppj.nombre_sig_jugador(posicion_atacante));
            var posicion_temporal_jugadorAtacante = atacante.transform.position;
            atacante.transform.position = new Vector3(afectado.transform.position.x, afectado.transform.position.y);
            afectado.transform.position = new Vector3(posicion_temporal_jugadorAtacante.x, posicion_temporal_jugadorAtacante.y);
            Debug.LogFormat("La posicion de {0} es: {1}. Se atacó a: {2}", atacante.name, posicion_atacante, afectado.name);
        }
        else
            Debug.Log("Lo tomó la primera posicion, no afectando a nada");
        Destroy(gameObject);
    }

}