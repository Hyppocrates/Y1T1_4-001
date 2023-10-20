using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    
    public Transform target;
    public float distance = 5.0f;
    public float sensitivity = 2.0f;

    private float rotationX = 0.0f;
    private float rotationY = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        //Hides the mouse cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    // Update is called once per frame
    void Update()
    {
        HandleCameraInput();
    }

    void LateUpdate()
    {
        FollowTarget();
    } 



    void HandleCameraInput()
    {
        // Rotate the camera based on mouse input
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;
        
        // Update the camera's vertical rotation (pitch) based on mouse input
        rotationX -= mouseY;
        rotationY += mouseX;

        // Clamp the vertical rotation
        rotationX = Mathf.Clamp(rotationX, 0, 90);
        rotationY = Mathf.Clamp(rotationY, -180, 180);
        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0);
        
        
       
    }

    void FollowTarget()
    {
        //Move camera to follow the player
        Vector3 targetPosition = target.position - transform.forward * distance;
        transform.position = targetPosition;

    }
}
