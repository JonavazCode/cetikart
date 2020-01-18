using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPath : MonoBehaviour
{
    [SerializeField]
    private GameObject[] checkpoints;
    
    public float speed = 1000f;
    public float rotationSpeed = 10f;

    public WheelJoint2D backWheel;
    public WheelJoint2D frontWheel;

    public Rigidbody2D rb;

    private float movement = 0f;
    public float rotation = 0f;

    public bool canJump;


    private int checkpointIndex = 0;
    private void Start()
    {
        checkpoints = GameObject.FindGameObjectsWithTag("Checkpoint");
        acomodar();

    }
    private void Update()
    {
        //"Run"
        // movement = -1 * speed;

        //  movement = 0;

        //"Freno"
        //   movement = 1 * speed;

        /*
        if (CrossPlatformInputManager.GetButton("Jump") && canJump)
        {
            canJump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1000f));
  
        }
        */


        /*
        if (checkpointIndex >= checkpoints.Length - 1)
        {
            movement = -1 * speed;

            if (transform.position == checkpoints[checkpointIndex].transform.position)
            {
                Debug.Log("entro");
                checkpointIndex--;
            }
        }
        else
        {
            movement = 0;
        }
        */

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

    private void acomodar()
    {
       GameObject[] cps = new GameObject[checkpoints.Length];

        int x = checkpoints.Length; //5
        int temp = x - 1; //4

        for (int i = 0; i < x; i++)
        {
            cps[i] = checkpoints[temp]; //cps[4] checkpints[0]
            temp--;
        }

        checkpoints = cps;
    }


}
