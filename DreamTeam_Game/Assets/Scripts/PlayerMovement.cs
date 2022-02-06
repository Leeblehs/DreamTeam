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
        // X-axis movement, speed, sets gravity to 1
        movement.x = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        // Check if TopDown is enabled
        TopDownMovement();
        
        // Jumping
        if (Input.GetKeyDown(KeyCode.Space) && !isTopDown) 
        {
            // Doesn't make the player jump atm, but does increase velocity shown in inspector, maybe I'm doing something wrong?
            float jumpVelocity = 100f;
            rb.velocity = Vector2.up * jumpVelocity;
            Debug.Log("Attempting to Jump");
        }
    }

    void TopDownMovement()
    {
        if(isTopDown == true)
        {
            // Disables Gravity, Enable Y-axis movement
            rb.gravityScale = 0;
            movement.y = Input.GetAxisRaw("Vertical");
            animator.SetFloat("Vertical", movement.y);
        }
        else
        {
            // temp fix, this would perma set gravity to 1 when not in topdown
            rb.gravityScale = 1;
        }
    }

    void FixedUpdate()
    {
        // Movement
        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
    }

}
