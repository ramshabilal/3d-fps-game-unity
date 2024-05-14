using UnityEngine;

public class HealthController : MonoBehaviour
{
    public float maxHealth = 200f;
    public float currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize current health to max health at the start of the game
        currentHealth = maxHealth;
    }

    // Method to take damage
    public void TakeDamage(float damage)
    {
        // Reduce current health by the damage amount
        currentHealth -= damage;
        print("Player health: " + currentHealth);
        // Check if the player's health has dropped to zero or below
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public float GetCurrentHealth()
    {
        // Return the current health value
        return currentHealth;
    }

    // Method to handle player death
    void Die()
    {
        // Perform actions when the player dies, such as game over, respawn, etc.
        print("Player has died!"); // Print a message to the console
        Debug.Log("Player has died!");
    }
}
