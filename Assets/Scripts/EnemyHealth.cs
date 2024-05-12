using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float startingHealth = 100f;  // Initial health of the enemy
    private float currentHealth;          // Current health of the enemy

    private void Start()
    {
        currentHealth = startingHealth;
    }

    // Function to reduce the enemy's health
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();  // If health drops to or below zero, call the Die function
        }
    }

    // Function to handle enemy death
    private void Die()
    {
        Destroy(gameObject);  // Destroy the enemy GameObject when it dies
    }
}
