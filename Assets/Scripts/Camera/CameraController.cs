using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject target;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - target.transform.position;
    }

    void Update()
    {
        if (!target) return;
        transform.position = target.transform.position + offset;
    }
}
