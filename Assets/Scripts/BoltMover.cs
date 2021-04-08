using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltMover : MonoBehaviour
{
    Rigidbody rb;
    float velocity = 20;
    private void Start() {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.up * velocity;
    }
}
