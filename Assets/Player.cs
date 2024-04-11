using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Karakterin maksimum sağlık değeri
    public int maxHealth = 100;

    // Karakterin mevcut sağlık değeri
    public int currentHealth;

    // UI sağlık çubuğunu temsil eden bir HealthBar nesnesi
    public HealthBar healthBar;

    void Start()
    {
        // Karakterin başlangıç sağlık değerini maksimum sağlık değeriyle eşitler
        currentHealth = maxHealth;

        // Sağlık çubuğunu başlangıç sağlık değeriyle günceller
        healthBar.SetMaxHealth(maxHealth);
    }

    // Her frame güncellemesi sırasında çağrılan fonksiyon
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Çarpışan nesne bir 'Enemy' ise
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Hasar al
            TakeDamage(30);
        }
    }

    // Karakterin zarar almasını sağlayan fonksiyon
    void TakeDamage(int damage)
    {
        // Karakterin mevcut sağlık değerini, aldığı hasar kadar azaltır
        currentHealth -= damage;

        // Sağlık çubuğunu, güncellenmiş mevcut sağlık değeriyle günceller
        healthBar.SetHealth(currentHealth);
    }
}
