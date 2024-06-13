using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovRPG : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 Movement;
    public Animator animator;
    
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (horizontal != 0 || vertical != 0)
        {
            animator.SetFloat("Horizontal", horizontal);
            animator.SetFloat("Vertical", vertical);
            animator.SetFloat("Speed", 1);
        }
        else
        {
            animator.SetFloat("Speed", 0);
        }

        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");

        transform.Translate(Vector3.right * horizontal * speed * Time.deltaTime);
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + Movement * moveSpeed * Time.fixedDeltaTime);
    }
}
