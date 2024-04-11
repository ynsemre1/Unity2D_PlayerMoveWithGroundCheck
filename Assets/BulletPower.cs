using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPower : MonoBehaviour
{
    public float forceAmount = 10f;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        AddForceInDirection(rb, forceAmount, transform.right);
    }

    void AddForceInDirection(Rigidbody2D rb, float force, Vector2 direction)
    {
        // Belirlenen yön ve kuvvetle kuvvet uygula
        rb.AddForce(-direction * force, ForceMode2D.Impulse);
    }
}
