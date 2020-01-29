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
    public Animator animacion;

    private int checkpointIndex = 0;
    public float speedPERdif;

    public Dificultad niv_dif;
    public char[] clone;

    public void Awake()
    {
        clone = new char[] { '(', 'C', 'l', 'o', 'n', 'e', ')' };
        this.name = this.name.TrimEnd(clone);
    }

    private void Start()
    {

        
        checkpoints = GameObject.FindGameObjectsWithTag("Checkpoint");
        acomodar();
        niv_dif = FindObjectOfType<Dificultad>();
        if (niv_dif.nivel_dificultad == 1)
        {
            speedPERdif = 900f;
            speed = 900f;
        }

        if (niv_dif.nivel_dificultad == 2)
        {
            speedPERdif = 1100f;
            speed = 1100f;
        }

        if (niv_dif.nivel_dificultad == 3)
        {
            speedPERdif = 1200f;
            speed = 1200f;
        }
    }
    private void Update()
    {
       
        //"Run"
        movement = -1 * speed;

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
