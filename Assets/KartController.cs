using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class KartController : MonoBehaviour
{
    public float speed;
    public float rotationSpeed = 12f;

    public WheelJoint2D backWheel;
    public WheelJoint2D frontWheel;

    public Rigidbody2D rb;

    public float movement = 0f;
    public float rotation = 0f;

    public bool canJump;


    public bool item_cohete_fly = false;

    private LevelManager levelManager; //instancia de LevelManager
    private CheckpointsPerPJ cpp;
    public Dificultad niv_dif;
    public float speedPERdif;

    
    

    public void Start()
    {
        
        levelManager = FindObjectOfType<LevelManager>(); //encuentra el objeto LevelManager
        cpp = FindObjectOfType<CheckpointsPerPJ>();
        niv_dif = FindObjectOfType<Dificultad>();

        if (niv_dif.nivel_dificultad == 1)
        {
            speedPERdif = 700f;
            speed = 700f;
        }

        if (niv_dif.nivel_dificultad == 2)
        {
            speedPERdif = 1000f;
            speed = 1000f;
        }

        if (niv_dif.nivel_dificultad == 3)
        {
            speedPERdif = 1200f;
            speed = 1200f;
        }


    }
    private void Update()
    {

       

        if (CrossPlatformInputManager.GetButton("Run") || Input.GetKey(KeyCode.D))
            movement = -1 * speed;
        else
            movement = 0;

        if (CrossPlatformInputManager.GetButton("Freno") || Input.GetKey(KeyCode.A))
            movement = 1 * speed;
 

        if ((CrossPlatformInputManager.GetButton("Jump") || Input.GetKeyDown(KeyCode.Space)) && canJump )
        {
            canJump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1000f));
        }

        //Si toma el cohete y pulsa el espacio podrá saltar
        if ((CrossPlatformInputManager.GetButton("Jump") || Input.GetKeyDown(KeyCode.Space)) && item_cohete_fly && !canJump)
        {
            StartCoroutine(esperar_milisegundos(.15f));
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 300f));
        }

        if (CrossPlatformInputManager.GetButton("PuntoControl") || Input.GetKeyDown(KeyCode.K))
        {
            if (this.name.Contains("molina"))
            {
                levelManager.RespawnPlayer(this.name, cpp.molina);
            }
            else if (this.name.Contains("coco"))
            {
                levelManager.RespawnPlayer(this.name, cpp.coco);
            }
            else if (this.name.Contains("nino"))
            {
                levelManager.RespawnPlayer(this.name, cpp.nino);
            }
            else if (this.name.Contains("agentek"))
            {
                levelManager.RespawnPlayer(this.name, cpp.agentek);
            }
            else if (this.name.Contains("sergio"))
            {
                levelManager.RespawnPlayer(this.name, cpp.sergio);
            }
            else if (this.name.Contains("areli"))
            {
                levelManager.RespawnPlayer(this.name, cpp.areli);
            }
            else if (this.name.Contains("gussa"))
            {
                levelManager.RespawnPlayer(this.name, cpp.gussa);
            }
            else if (this.name.Contains("ulyses"))
            {
                levelManager.RespawnPlayer(this.name, cpp.ulyses);
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

    IEnumerator esperar_milisegundos(float seg)
    {
        yield return new WaitForSeconds(seg);
    }


}
