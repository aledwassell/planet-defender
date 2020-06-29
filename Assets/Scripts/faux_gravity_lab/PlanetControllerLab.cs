using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetControllerLab : MonoBehaviour
{
    public float gravity = -10;

    public void Gravitate(Transform other)
    {
        Vector3 gravityUp = (other.position - transform.position).normalized;
        Vector3 otherUp = other.up;

        other.GetComponent<Rigidbody>().AddForce(gravityUp * gravity);

        Quaternion targetRotation = Quaternion.FromToRotation(otherUp, gravityUp) * other.rotation;
        other.rotation = Quaternion.Slerp(other.rotation,targetRotation, 50 * Time.deltaTime);
    }
}
