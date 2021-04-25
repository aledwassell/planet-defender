using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller_2D : MonoBehaviour
{
    private Rigidbody2D rb;
    public float playerSpeed = 20;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezePosition;
        rb.useAutoMass = false;
    }

    private void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");

        Vector2 move2D = new Vector2(moveH, 0).normalized;
        
        rb.MovePosition(rb.position * (playerSpeed * Time.deltaTime));
    }
}
