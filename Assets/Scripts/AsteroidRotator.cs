using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRotator : MonoBehaviour
{
    public float tumble = 10;
    Rigidbody rb;
    void Start() {
        rb = GetComponent<Rigidbody>();
        rb.angularVelocity = Random.insideUnitSphere * tumble;
    }
}
