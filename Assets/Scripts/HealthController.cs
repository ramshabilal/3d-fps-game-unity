using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;

    // Events for health-related actions
    public delegate void HealthChangeEvent(float currentHealth, float maxHealth);
    public event HealthChangeEvent OnHealthChanged;
    public event HealthChangeEvent OnHealthDepleted;

    private void Start()
    {
        // Initialize current health to max health when the object is created
        currentHealth = maxHealth;
    }

    // Method to take damage
    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
        currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth); // Ensure health doesn't go below 0 or above maxHealth
        print("Health: " + currentHealth + "/" + maxHealth);
        // Trigger event when health changes
        OnHealthChanged?.Invoke(currentHealth, maxHealth);

        // Check if health has been depleted
        if (currentHealth <= 0f)
        {
            // Trigger event when health is depleted
            OnHealthDepleted?.Invoke(currentHealth, maxHealth);
        }
    }

    // Method to heal
    public void Heal(float healAmount)
    {
        currentHealth += healAmount;
        currentHealth = Mathf.Clamp(currentHealth, 0f, maxHealth); // Ensure health doesn't exceed maxHealth

        // Trigger event when health changes
        OnHealthChanged?.Invoke(currentHealth, maxHealth);
    }
}
