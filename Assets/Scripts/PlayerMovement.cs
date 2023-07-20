using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float movement;
    [SerializeField] Rigidbody2D rigidBody;
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    bool canJump;
    [SerializeField] Animator animator;
    void Start()
    {

    }
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
        rigidBody.velocity = new Vector2(movement * speed, rigidBody.velocity.y);

        if (movement == -1)
        {
            transform.localScale = new Vector2(-1, transform.localScale.y);

        }
        if (movement == 1)
        {
            transform.localScale = new Vector2(1, transform.localScale.y);
        }

        if (Input.GetButtonDown("Jump") && canJump)
        {
            rigidBody.AddForce(Vector2.up * jumpForce);

            if(animator.GetBool("isGrounded") == false)
            {
                canJump = false;
            }
        }
    }

    private void FixedUpdate()
    {
        if (movement == 0)
        {
            animator.SetBool("isWalking", false);
        }
        else { animator.SetBool("isWalking", true); }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        animator.SetBool("isGrounded", true);
        canJump = true;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("isGrounded", false);
    }
}
