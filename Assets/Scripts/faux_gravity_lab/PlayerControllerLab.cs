using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerLab : MonoBehaviour
{
    private Rigidbody rb;

    public PlanetControllerLab planet;

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

        Vector3 move3d = new Vector3(mHorizontal, 0, mVertical).normalized;

        rb.MovePosition(rb.position + transform.TransformDirection(move3d) * speed * Time.deltaTime);
    }
}
