using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRoomba : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10f;
    
       
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
        
    }

    // Update is called once per frame
    void Update()
    {
       PlayerMove();
    }

    void PrintInstructions()
    {

        Debug.Log("Welcome to the game of Roomba Challenge!");
        Debug.Log("Use WASD keys to move");
        Debug.Log("Alternatively");
        Debug.Log("Use arrow keys");
        Debug.Log("Try not to hit the furniture while cleaning");
    }

    void PlayerMove()
    {

        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Translate(xValue * moveSpeed, 0, zValue * moveSpeed);
    }
}
