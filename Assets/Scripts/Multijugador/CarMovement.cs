using Photon.Pun;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CarMovement : MonoBehaviourPun
{
    [SerializeField]
    public float speed = 1000f;
    private float rotationSpeed = 12f;

    public WheelJoint2D backWheel;
    public WheelJoint2D frontWheel;
    public Rigidbody2D rb;

    public bool controlsEnabled;

    private int reductor = 10;
    private float movement = 0f;
    private float rotation = 0f;

    public bool canJump;
    // Start is called before the first frame update


    [Header("Variables de Cohete")]
    public bool ControlCohete = false;
    public float SpeedCohete = 100f;
    public Vector2 input;
    void Start()
    {
        controlsEnabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (controlsEnabled)
        {
            if (CrossPlatformInputManager.GetButton("Run") || Input.GetKey(KeyCode.D))
                movement = -1 * speed;
            else
                movement = 0;

            if (CrossPlatformInputManager.GetButton("Freno") || Input.GetKey(KeyCode.A))
                movement = 1 * speed;

            if ((CrossPlatformInputManager.GetButton("Jump") || Input.GetKeyDown(KeyCode.Space)) && canJump)
            {
                canJump = false;
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(250f, 1000f));
            }
        }

    }

    private void FixedUpdate()
    {
        if (movement == 0f)
        {
            backWheel.useMotor = false;
            frontWheel.useMotor = false;
            if (rb.angularVelocity > 0)
            {
                rb.angularVelocity -= 0.01f; 
            }
            if (rb.angularVelocity < 0)
            {
                rb.angularVelocity += 0.01f;
            }
        }
        else
        {
            backWheel.useMotor = true;
            frontWheel.useMotor = true;

            JointMotor2D motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = 10000 };
            backWheel.motor = motor;
            frontWheel.motor = motor;
            rb.AddTorque(rotation * rotationSpeed * Time.fixedDeltaTime);
        }
        //rb.AddTorque(rotation * rotationSpeed * Time.fixedDeltaTime);
        if (ControlCohete)
        {
            if (CrossPlatformInputManager.GetButton("Run") || Input.GetKey(KeyCode.D))
            {
                if (input.x <= 5f)
                    input.x += 0.050f;
                rb.velocity = input * SpeedCohete * Time.fixedDeltaTime;
            }
            else
                input.x = 0f;

            if (CrossPlatformInputManager.GetButton("Jump") || Input.GetKey(KeyCode.Space))
            {
                input.y += 0.1f;
                rb.velocity = input * SpeedCohete * Time.fixedDeltaTime;
            }
            else
                input.y = -1f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "grounder")
        {
            canJump = true;
        }
    }

    [PunRPC]
    public void ActualizarVelocidad(float velocidad)
    {
        speed += velocidad;
    }

    public void ControlesCohete()
    {
        ControlCohete = !ControlCohete;
    }
}
