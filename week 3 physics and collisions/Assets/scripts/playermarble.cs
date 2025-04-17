using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleController : MonoBehaviour
{
    public float moveSpeed = 10f; // Speed of marble
    public float maxSpeed = 20f; // Max speed for the marble

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Assign Rigidbody component
    }

    void Update()
    {
        // Get player input
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        // Apply movement with force for smooth acceleration
        if (rb.linearVelocity.magnitude < maxSpeed)
        {
            rb.AddForce(movement * moveSpeed);
        }
    }
}

