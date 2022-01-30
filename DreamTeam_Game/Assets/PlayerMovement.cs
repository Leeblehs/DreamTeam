using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 2.5f;
    public bool isTopDown;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    // Update is called once per frame

    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        // Input
        movement.x = Input.GetAxisRaw("Horizontal");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        TopDownMovement();

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            float jumpVelocity = 100f;
            rb.velocity = Vector2.up * jumpVelocity;
        }
    }

    void TopDownMovement()
    {
        if(isTopDown == true)
        {
            movement.y = Input.GetAxisRaw("Vertical");
            animator.SetFloat("Vertical", movement.y);
        }
    }

    void FixedUpdate()
    {
        // Movement
        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
    }

}
