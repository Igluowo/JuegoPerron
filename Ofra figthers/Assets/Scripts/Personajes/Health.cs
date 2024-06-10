using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int numLives = 5;
    public float currentHealth = 0f;

    public void TakeDamage(float amount)
    {
        currentHealth += amount;
    }

    public void LoseLife()
    {
        numLives -= 1;
        if (numLives < 0)
        {
            // Trigger event
        }
    }

    public void Heal(int amount)
    {
        currentHealth -= amount;
    }
}
