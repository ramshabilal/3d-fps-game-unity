using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public Text healthText;
    public HealthController healthController;

    private void Start()
    {
        // Get a reference to the HealthController component
        if (healthController == null)
        {
            healthController = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthController>();
        }

        // Update the health text initially
        UpdateHealthText();
    }

    private void UpdateHealthText()
    {
        // Update the health text with the current health value
        if (healthText != null && healthController != null)
        {
            healthText.text = "Health: " + healthController.GetCurrentHealth().ToString();
            print("Health: " + healthController.GetCurrentHealth().ToString());
        }
    }

    private void Update()
    {
        // Update the health text continuously
        UpdateHealthText();
    }
}
