using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoPlayer : MonoBehaviour
{
    public float movForce;
    public float jumpForce;
    public bool canJump;
    private Rigidbody2D rb;
    public GameObject bala;
    Animator animator;
    SpriteRenderer SpriteRender;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        SpriteRender.flipX = false;
        
    }
    void Update()
    {
        if (Input.GetKey("left")) 
        {
            rb.AddForce(-transform.right * movForce * Time.deltaTime);
            SpriteRender.flipX = true;
        }
        if (Input.GetKey("right")) 
        {
            rb.AddForce(transform.right * movForce * Time.deltaTime);
            animator.SetBool("caminarr", true);
            SpriteRender.flipX = false;
        }

        if (Input.GetKeyDown("up") && canJump)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0));
            canJump = false;
            animator.SetBool("jump", true);
        }

        if (!Input.anyKey)
        {
            //ejecuta la animación "parado_idle"
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Disparo");
            //Instantiate(bala, transform.position, transform.rotation);
            funcionDisparo();
        }

       

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "nose")
        {
            canJump = true;
            animator.SetBool("jump", false);
        }
       
    }
    public void funcionDisparo()
    {
        Instantiate(bala, transform.position, transform.rotation);
    }
}
