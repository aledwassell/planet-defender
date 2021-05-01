using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;
    public GameManager gm;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Boundary")) return;
        Instantiate(explosion, transform.position, transform.rotation);
        if (other.CompareTag("Player"))
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
        }
        Destroy(gameObject);
        if (other.CompareTag("Planet") || other.CompareTag("Fauna")) return;
        Destroy(other.gameObject);
    }
}
