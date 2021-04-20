using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayViewer : MonoBehaviour
{
    private float weaponRange = 50f;

    public Transform gunEnd;

    void Start()
    {
        gunEnd = GetComponent<Transform>();
    }

    void Update()
    {
        Vector3 lineOrigin = gunEnd.position;
        Debug.DrawRay(lineOrigin, gunEnd.up * weaponRange, Color.red);
    }
}
