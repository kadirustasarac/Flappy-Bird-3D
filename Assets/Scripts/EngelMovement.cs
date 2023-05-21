using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngelMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 0.01f;
    Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        movement = new Vector3(-movementSpeed,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 startPosition = transform.position;
        transform.position = startPosition + movement;

        if(transform.position.x < -13) Destroy(gameObject);
    }
}
