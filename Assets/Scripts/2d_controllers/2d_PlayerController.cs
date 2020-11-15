using System.Collections;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

using Debug = UnityEngine.Debug;

public class PlayerController2D : MonoBehaviour
{
    public float velocity = 10;

    private Rigidbody2D rb2d;

    public PlanetController2D planet;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.isKinematic = false;
        rb2d.gravityScale = 0;
    }

    void Update()
    {
        planet.Gravitate(transform);
    }

    void FixedUpdate()
    {
        float hMove = Input.GetAxis("Horizontal");
        float vMove = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(hMove, vMove).normalized;

        Vector2 force = (rb2d.position * transform.TransformDirection(move) * velocity * Time.deltaTime);

        rb2d.AddForce(move);
    }
}
