using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public Transform player;
    public float speed;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 desiredPos = player.position + offset;
        transform.position  = Vector3.Lerp(transform.position, desiredPos , speed * Time.deltaTime);    
    }
}
