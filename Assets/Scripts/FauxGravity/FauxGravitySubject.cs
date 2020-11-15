using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravitySubject : MonoBehaviour
{
    Rigidbody rb;
    FauxGravityBody planetCtrl;

    void Start()
    {
        planetCtrl = GameObject.FindGameObjectWithTag("Planet").GetComponent<FauxGravityBody>();
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    void FixedUpdate()
    {
        planetCtrl.Gravitate(transform);
    }
}
