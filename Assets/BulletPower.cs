using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPower : MonoBehaviour
{
    public float forceAmount = 10f;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        AddLocalForceInDirection(rb, forceAmount, -transform.up);
    }

    void AddLocalForceInDirection(Rigidbody2D rb, float force, Vector2 localDirection)
    {
        // Nesnenin yerel yönünü dünya koordinat sistemi içindeki yönüne dönüştür
        Vector2 worldDirection = rb.transform.TransformDirection(localDirection);

        // Kuvvet uygula
        rb.AddForce(worldDirection * force, ForceMode2D.Impulse);
    }
}
