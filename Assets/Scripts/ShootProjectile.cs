using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
    public Rigidbody2D pfBolt;
    public float projectileVelocity = 20;
    public Transform projectileSpawn;
    
    public float fireRate;
    float nextFire;
    
    void Update()
    {
        if (!Input.GetButton("Fire1") || Time.time < nextFire) return;
        nextFire = Time.time + fireRate;
        Rigidbody2D projectile = Instantiate(pfBolt, projectileSpawn.position, projectileSpawn.rotation);
        projectile.velocity = projectileSpawn.up * projectileVelocity;
    }
}
