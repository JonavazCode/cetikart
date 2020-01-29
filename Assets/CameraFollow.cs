using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform playerTransform;


    public float smoothness;
    public Vector3 Velocity;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;   
    }
    void LateUpdate()
    {

        Vector3 target = new Vector3(playerTransform.position.x, playerTransform.position.y, -10f);
        transform.position = Vector3.SmoothDamp(transform.position, target, ref Velocity, smoothness);

    }
}
