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

    void FixedUpdate() {
        float mHorizontal = Input.GetAxis("Horizontal");
        // float mVertical = Input.GetAxis("Vertical");

        Vector3 move3d = new Vector3(mHorizontal, 0, 0).normalized;

        rb.MovePosition(rb.position + transform.TransformDirection(move3d) * playerSpeed * Time.deltaTime);
    }
}
