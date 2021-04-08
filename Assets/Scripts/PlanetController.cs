using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetController : MonoBehaviour
{
    public CameraShake cameraShake;
    public GameObject explosion;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bolt")
        {
            Destroy(other.gameObject);
        }
        if (other.tag == "Asteroid")
        {
            StartCoroutine(cameraShake.Shake(.15f, .5f));
        }
    }
}
