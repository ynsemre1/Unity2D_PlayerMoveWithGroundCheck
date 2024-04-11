using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreator : MonoBehaviour
{
    public GameObject prefabToSpawn; // Spawn edilecek prefab
    private float move;

    void Start()
    {
    }

    void Update()
    {
        // Sol tıklama (Mouse0) algılandığında
        if (Input.GetMouseButtonDown(0))
        {
            // Fare pozisyonundaki noktaya spawn et
            Vector3 spawnPosition = transform.position;
            Vector3 forwardDirection = transform.forward; // Karakterin ileriye bakış yönü
            Vector3 targetPosition = transform.position + forwardDirection; // Hedef pozisyon, karakterin ileriye bakış yönüne göre biraz ilerisinde


            spawnPosition.z = 0f; // Z konumunu sabitle (2D ortamda)

            // Prefabı spawn et
            GameObject spawnedObject = Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
            Vector3 spawnDirection = (targetPosition - spawnPosition).normalized;
            float angle = Mathf.Atan2(spawnDirection.y, spawnDirection.x) * Mathf.Rad2Deg;
            spawnedObject.transform.rotation = Quaternion.Euler(0, 0, angle);
        }

        move = Input.GetAxis("Horizontal");

        if (move < 0)
{
    transform.localPosition = new Vector3(.88f, 0f, 0f);
    transform.localRotation = Quaternion.Euler(0f, 180f, 0f);
}

if (move > 0)
{
    transform.localPosition = new Vector3(-.88f, 0f, 0f);
    transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
}
    }
}
