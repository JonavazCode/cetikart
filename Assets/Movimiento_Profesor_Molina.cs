using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Animations;

public class Movimiento_Profesor_Molina : MonoBehaviour
{
    public float maxSpeed = 80f;
    public float maxSpeedN = 0f;
    public float speed = 10f;
    public bool grounder;
    private Rigidbody2D molina;
    private Animator anim;
    public float jumpPower = 1f;
    private bool jump;
    public bool freno;
    public float h;
   
    
    
    //public int cargasValor;



    // Use this for initialization
    void Start()
    {
        molina = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        grounder = true;
        freno = false;
        
        
        
    }
    void Update()
    {
        /*anim.SetFloat("speed", Mathf.Abs(molina.velocity.x));
        anim.SetBool("grounder", grounder);
        anim.SetBool("freno", freno);*/

        /*Item cargas01 = GetComponent<Item>();
        cargasValor = cargas01.cargas;*/
        


        if (CrossPlatformInputManager.GetButton("Jump") && grounder)
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        if (CrossPlatformInputManager.GetButton("Run"))
        {
            
            
            molina.AddForce(Vector2.right * speed * h);
            h++;

            float limitedSpeed = Mathf.Clamp(molina.velocity.x, -maxSpeed, maxSpeed);
            molina.velocity = new Vector2(limitedSpeed, molina.velocity.y);



        }
        else {
            

        }
        if (CrossPlatformInputManager.GetButton("Freno"))
        {

            
            molina.AddForce(Vector2.left * speed * h);
            h--;
            float limitedSpeed = Mathf.Clamp(molina.velocity.x, -maxSpeedN, maxSpeedN);
            molina.velocity = new Vector2(limitedSpeed, molina.velocity.y);
            freno = true;

            
        }
        else
        {
            freno = false;
        }
        if (CrossPlatformInputManager.GetButton("PowerUp"))
        {
            anim.SetTrigger("PowerUp");

        }


            if (jump)
        {
            molina.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            jump = false;
            Debug.Log(grounder);
        }
    }

   

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.transform.tag == "grounder" && !grounder)
        {

            grounder = true;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {

        if (col.transform.tag == "grounder" && grounder)
        {

            grounder = false;
        }
    }

    void OnCollisionStay2D(Collision2D col)
    {

        if (col.transform.tag == "grounder" && !grounder)
        {

            grounder = true;
        }
    }
   
}