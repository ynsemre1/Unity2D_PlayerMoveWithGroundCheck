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
            Vector3 spawnPosition = transform.position;
            Vector3 forwardDirection = transform.forward; // Karakterin ileriye bakış yönü
            Vector3 targetPosition = transform.position + forwardDirection; // Hedef pozisyon, karakterin ileriye bakış yönüne göre biraz ilerisinde
            Vector3 spawnDirection = (targetPosition - spawnPosition).normalized;


            spawnPosition.z = 0f; // Z konumunu sabitle (2D ortamda)

            float angle = Mathf.Atan2(spawnDirection.y, spawnDirection.x) * Mathf.Rad2Deg;

            // Prefabı spawn et
            GameObject spawnedObject = Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
            if (transform.rotation.y == 180f)
            {
                spawnedObject.transform.rotation = Quaternion.Euler(0, 0f, -90f);
            }

            if (transform.rotation.y == 360f)
            {
                spawnedObject.transform.rotation = Quaternion.Euler(0, 0f, 90f);

            }

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
