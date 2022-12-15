using System;
using UnityEngine;
using TMPro;

public class HealthObject : MonoBehaviour
{
    [SerializeField] TMP_Text textComponent;
    [SerializeField] int maxHealth = 100;

    [SerializeField] Color maxHealthColor;
    [SerializeField] Color zeroHealthColor;
    [SerializeField] GameObject objectToTurnOnWhenDie;

    int currentHealth;

    const string healthKey = "health"; //konstans érték

    private void Awake()
    {
        if(PlayerPrefs.HasKey(healthKey)) // rákérdezünk, hogy létezik e a health
        {
            currentHealth = PlayerPrefs.GetInt(healthKey);
        }

    }
    private void OnDestroy()
    {
        PlayerPrefs.SetInt(healthKey, currentHealth); // health kulcsszó alá elmentem a currenthealth-t
    }

    private void Start()
    {
        if (PlayerPrefs.HasKey(healthKey)) // rákérdezünk, hogy létezik e a health
        {
            currentHealth = PlayerPrefs.GetInt(healthKey);
        }
        if (currentHealth <= 0)
        {
            currentHealth = maxHealth;
        }

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
        TestDeath();
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
        TestDeath();
    }

    void TestDeath()
    {
        if(IsDead())
        {
            objectToTurnOnWhenDie?.SetActive(true); //"?." ha nem null akkor mûküdjön
        }
    }
}
