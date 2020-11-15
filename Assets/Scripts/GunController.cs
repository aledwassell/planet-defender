using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public Transform projectileSpawn;
    private Vector3 lookDirection;
    private float lookAngle;

    // Update is called once per frame
    void Update()
    {
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        projectileSpawn.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90f);
    }
}
