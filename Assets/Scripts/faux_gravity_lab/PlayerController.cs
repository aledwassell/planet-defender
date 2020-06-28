using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    public PlanetController planet;

    public float speed = 10;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        rb.useGravity = false;
    }

    void Update() {
        planet.Gravitate(transform);
    }

    void FixedUpdate()
    {
        float mHorizontal = Input.GetAxis("Horizontal");
        float mVertical = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }

        Vector3 move3d = new Vector3(mHorizontal, 0, mVertical).normalized;

        rb.MovePosition(rb.position + transform.TransformDirection(move3d) * speed * Time.deltaTime);
    }

    jump()
    {
        Vector3 up = transform.TransformDirection(Vector3.up);
        rigidbody.AddForce(up * jumpForce);
    }
}
