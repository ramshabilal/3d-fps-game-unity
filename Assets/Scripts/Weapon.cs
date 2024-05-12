using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float fireRate = 0.2f; // Rate of fire in seconds
    public float damage = 10f;    // Damage inflicted by each shot
    public Transform firePoint;   // Point from which bullets are fired
    public GameObject bulletPrefab; // Prefab of the bullet GameObject

    private float nextFireTime;   // Time when the next shot can be fired
    public bool canUse = true; 

    private void Update()
    {
        // Check if it's time to fire again
        if (Input.GetButtonDown("Fire1") && Time.time >= nextFireTime)
        {
            // Fire a bullet
            Fire();
            // Update the time for the next shot
            nextFireTime = Time.time + fireRate;
        }
    }

    public void Fire()
    {
        // Instantiate a new bullet GameObject at the fire point
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        // Set the bullet damage
        bullet.GetComponent<Bullet>().damage = damage;
        // Destroy the bullet after a certain time (adjust the time to match bullet travel speed)
        Destroy(bullet, 2f);
    }
}
