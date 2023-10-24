using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class SimpleArrayExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Declare and initialise an array of integers
        int[] Numbers = {1,2,3,4,5};

        // Replace the number 3 with 6
        for (int i = 0; i <Numbers.Length; i++)
        {
            if (Numbers[i] ==3)
            {
                Numbers[i] =6;
                break; // Exit the loop after the replacement 

            }

        }

        //  Access and display array elements
        Debug.Log("Array elements after replacement:");

        for (int i = 0; i <Numbers.Length; i++)
        {
            Debug.Log("Element " +i+": " +Numbers[i]);


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
