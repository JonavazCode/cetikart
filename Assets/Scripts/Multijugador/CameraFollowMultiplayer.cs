using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowMultiplayer : MonoBehaviour
{
    
    private Transform playerTransform;
    private bool findPlayer = false;


    public float smoothness;
    public Vector3 Velocity;

    void Update()
    {
        if (!findPlayer)
        {
            try
            {
                playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
                findPlayer = true;
            }
            catch
            {
                Debug.Log("Jugador no encontrado");
            }
            
        }
            
    }
    void LateUpdate()
    {
        Vector3 target = new Vector3(playerTransform.position.x, playerTransform.position.y, -10f);
        transform.position = Vector3.SmoothDamp(transform.position, target, ref Velocity, smoothness);

    }
    

}
