using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalMovement : MonoBehaviour
{
    
    public float moveSpeed = 1.0f;
    public float Amplitude = 1.0f;
    private Vector3 startPos;
    public float rotationSpeed = 50f;


    void Start()
    {
        
        startPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
        float verticalMovement = Mathf.Sin(Time.time * moveSpeed) * Amplitude;
        
        Vector3 newPosition = startPos + Vector3.up * verticalMovement;
        transform.position = newPosition;
        transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime);

    }
}
