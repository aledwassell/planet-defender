using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float playerSpeed = 20;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        rb.useGravity = false;
    }

    void FixedUpdate()
    {
        float mHorizontal = Input.GetAxis("Horizontal");
        float mVertical = Input.GetAxis("Vertical");

        Vector2 move2d = new Vector2(mHorizontal, 0).normalized;

        rb.MovePosition(rb.position + transform.TransformDirection(move2d) * (playerSpeed * Time.deltaTime));
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
