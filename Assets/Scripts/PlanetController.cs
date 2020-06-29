using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetController : MonoBehaviour
{
    public float gravity = -10;

    public void Gravitate(Transform other)
    {
        Vector2 gravityUp = (other.position - transform.position).normalized;
        Vector2 otherUp = other.up;

        other.GetComponent<Rigidbody>().AddForce(gravityUp * gravity);

        Quaternion targetRotation = Quaternion.FromToRotation(otherUp, gravityUp) * other.rotation;
        other.rotation = Quaternion.Slerp(other.rotation, targetRotation, 50 * Time.deltaTime);
    }
}
