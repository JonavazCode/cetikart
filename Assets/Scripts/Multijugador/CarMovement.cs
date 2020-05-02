using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
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


    private float movement = 0f;
    private float rotation = 0f;

    public bool canJump;
    // Start is called before the first frame update
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
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1000f));
            }
        }
        
    }

    private void FixedUpdate()
    {
        if (movement == 0f)
        {
            backWheel.useMotor = false;
            frontWheel.useMotor = false;
        }
        else
        {
            backWheel.useMotor = true;
            frontWheel.useMotor = true;

            JointMotor2D motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = 10000 };
            backWheel.motor = motor;
            frontWheel.motor = motor;
        }

        rb.AddTorque(rotation * rotationSpeed * Time.fixedDeltaTime);
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
        speed = velocidad;
    }

}
