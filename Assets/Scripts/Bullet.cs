using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;   // Speed of the bullet
    public float damage = 10f;  // Damage inflicted by the bullet

    private void Start()
    {
        // Set the velocity of the bullet in the forward direction
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the bullet collided with an enemy
        if (other.CompareTag("Enemy"))
        {
            // Damage the enemy
            other.GetComponent<EnemyHealth>().TakeDamage(damage);
            // Destroy the bullet on impact
            Destroy(gameObject);
        }
    }
}
