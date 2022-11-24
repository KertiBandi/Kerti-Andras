using System;
using UnityEngine;
using TMPro;

public class HealthObject : MonoBehaviour
{
    [SerializeField] TMP_Text textComponent;
    [SerializeField] int maxHealth = 100;

    [SerializeField] Color maxHealthColor;
    [SerializeField] Color zeroHealthColor;

    int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;

        UpdateTex();
    }

    private void UpdateTex()
    {
        textComponent.text = "Health: " + currentHealth;
        float healthRate = (float)currentHealth / maxHealth;
        textComponent.color = Color.Lerp(zeroHealthColor, maxHealthColor, healthRate);
    }

    public void Kill()
    {
        currentHealth = 0;
        UpdateTex();
    }

    public bool IsDead()
    {
        return currentHealth <= 0;
    }

    public void Damage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateTex();
    }
}
