using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform playerTransform;
    //public float offset;

    public float smoothness;
    public Vector3 Velocity;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;   
    }
    void LateUpdate()
    {
        /*
        //guardar la posición de la camara en la variable temp
        Vector3 temp = transform.position;

        // seteamos la posición x de la camára para que sea la misma que la posición x del jugador
        temp.x = playerTransform.position.x;
        //agregar un offset
        temp.x += offset;
        //asignar la posición de la cámara a la variable temporal con la posición del jugador
        transform.position = temp;
        */

        Vector3 target = new Vector3(playerTransform.position.x, playerTransform.position.y, -10f);
        transform.position = Vector3.SmoothDamp(transform.position, target, ref Velocity, smoothness);

    }
}
