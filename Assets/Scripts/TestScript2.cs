using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript2 : MonoBehaviour
{
    public float speed = 5.0f;
    public float sensitivity = 5.0f;
    public Transform target;
    public float distance = 5.0f;
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

    // Move the camera forward, backward, left, and right
    transform.position += transform.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime;
    transform.position += transform.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;

    // Rotate the camera based on the mouse movement
    float mouseX = Input.GetAxis("Mouse X");
    float mouseY = Input.GetAxis("Mouse Y");
    transform.eulerAngles += new Vector3(-mouseY * sensitivity, mouseX * sensitivity, 0);

    }

    void FollowTarget()
    {
         //Move camera to follow the player
        Vector3 targetPosition = target.position - transform.forward * distance;
        transform.position = targetPosition;

    }
}
