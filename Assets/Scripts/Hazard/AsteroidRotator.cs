using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRotator : MonoBehaviour
{
    public float tumble = 10;
    public Rigidbody rb;
    
    void Start() {
        rb.angularVelocity = Random.insideUnitSphere * tumble;
    }
}
