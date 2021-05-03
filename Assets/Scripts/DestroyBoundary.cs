using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBoundary : MonoBehaviour
{
    private void OnTriggerExit(Collider other) {
        Debug.Log(other.tag);
        Destroy(other.gameObject);
    }
}
