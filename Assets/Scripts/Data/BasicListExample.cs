using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicListExample : MonoBehaviour
{
    
    // Declare a list of strings to store names
    public List<string> names = new List<string>();

    void Start()
    {
        // Adding names to the list
        names.Add("Darius The Great");

        names.Add("Alexander The Great");

        names.Add("Arthur The Great");

        // Access and display list elements 
        Debug.Log("List elements:");

        // Iterate through the list and display each name
        foreach (string name in names)
        {
            // Print each name in the Unity console
            Debug.Log("Name: " + name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
