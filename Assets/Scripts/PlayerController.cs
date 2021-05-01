using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 20f;
    public Rigidbody2D rb;
    private Vector2 movement;

    private void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        rb.AddRelativeForce(Vector2.right * movement * playerSpeed);
    }

    private void OnCollisionEnter(Collision other)
    {
        // We don't want the player geometry to move, so ignore collisions from trees and rocks.
        if (!other.gameObject.CompareTag("Planet"))
        {
            Physics.IgnoreCollision(other.collider, GetComponent<Collider>());
        }
    }
}
