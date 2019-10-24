using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControllerx : MonoBehaviour
{
    public float speed = 1000f;
    public float rotationSpeed = 15f;

    public WheelJoint2D backWheel;
    public WheelJoint2D frontWheel;

    public Rigidbody2D rb;

    private float movement = 0f;
    private float rotation = 0f;

    private void Update()
    {
        movement = -Input.GetAxisRaw("Vertical") * speed;
        rotation = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1000f));
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
            backWheel.useMotor = true;

            JointMotor2D motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = 10000 };
            backWheel.motor = motor;
            frontWheel.motor = motor;
        }

        rb.AddTorque(rotation * rotationSpeed * Time.fixedDeltaTime);
    }
}
