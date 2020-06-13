using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetController : MonoBehaviour
{
    public float gravity = -10;

    public GameObject[] gSubjects;

    private void Awake()
    {
        gSubjects = GameObject.FindGameObjectsWithTag("gSubject");
    }

    void FixedUpdate()
    {
        foreach (GameObject gSubject in gSubjects)
        {
            Gravitate(gSubject.transform);
        }
    }

    public void Gravitate(Transform other)
    {
        Vector3 gravityUp = (other.position - transform.position).normalized;
        Vector3 localUp = other.up;

        other.GetComponent<Rigidbody2D>().AddForce(gravityUp * gravity);
    }
}
