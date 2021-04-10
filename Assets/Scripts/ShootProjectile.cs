using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
    public Rigidbody pfBolt;
    public float projectileVelocity = 20;
    public Transform projectileSpawn;
    public float fireRate;
    float nextFire;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Rigidbody projectile = Instantiate(pfBolt, projectileSpawn.position, projectileSpawn.rotation);
            projectile.velocity = projectileSpawn.up * projectileVelocity;
        }
    }
}
