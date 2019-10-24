using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class KartController : MonoBehaviour
{
    public float speed = 1500f;
    public float rotationSpeed = 12f;

    public WheelJoint2D backWheel;
    public WheelJoint2D frontWheel;

    public Rigidbody2D rb;

    private float movement = 0f;
    public float rotation = 0f;
    private bool isRun;
    private bool jump;
    private bool brake;

    private bool canJump;

    private void Update()
    {
        if (isRun)
            movement = -1 * speed;
        else
            movement = 0;

        if (brake)
            movement = 1 * speed;
 

        if (jump && canJump)
        {
            canJump = false;
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "grounder")
        {
            canJump = true;
        }
    }

    //run
    public void Pressed()
    {
        isRun = true;
    }

    public void NotPressed()
    {
        isRun = false;
    }

    //reversa
    public void Reversa()
    {
        brake = true;
    }
    public void NotReversa()
    {
        brake = false;
    }

    //jump
    public void Jump()
    {
        jump = true;
    }
    public void NotJumpt()
    {
        jump = false;
    }
}
