using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravitySubject : MonoBehaviour
{
    Rigidbody2D rb;
    FauxGravityBody planetCtrl;
    public float gravity = -20;

    void Start()
    {
        planetCtrl = GameObject.FindGameObjectWithTag("Planet").GetComponent<FauxGravityBody>();
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
    }

    void FixedUpdate()
    {
        planetCtrl.Gravitate(transform, rb, gravity);
    }
}
