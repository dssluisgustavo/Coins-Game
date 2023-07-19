using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float movement;
    [SerializeField] Rigidbody2D rigidBody;
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    void Start()
    {

    }
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
        rigidBody.velocity = new Vector2(movement * speed, rigidBody.velocity.y);

        if(movement == -1)
        {
            transform.localScale = new Vector2(-1, transform.localScale.y);

        }
        if(movement == 1)
        {
            transform.localScale = new Vector2(1, transform.localScale.y);
        }

        if (Input.GetButtonDown("Jump"))
        {
            rigidBody.AddForce(Vector2.up * jumpForce);
        }
    }

}
