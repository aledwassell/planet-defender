using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRotator : MonoBehaviour
{
    public float tumble = 10;
    Rigidbody2D rb;
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        // rb.angularVelocity = Random.insideUnitSphere * tumble;
    }
}
