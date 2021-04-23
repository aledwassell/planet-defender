using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityBody : MonoBehaviour
{
    public void Gravitate(Transform other, Rigidbody rb, float gravity)
    {
        Vector3 gravityUp = (other.position - transform.position).normalized;
        Vector3 otherUp = other.up;

        rb.AddForce(gravityUp * gravity);

        var rotation = other.rotation;
        
        Quaternion targetRotation =
            Quaternion.FromToRotation(otherUp, gravityUp) * rotation;
        
        rotation =
            Quaternion.Slerp(rotation, targetRotation, 50 * Time.deltaTime);
        other.rotation = rotation;
    }
}
