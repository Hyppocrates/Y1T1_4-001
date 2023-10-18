using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BumpObjects : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log ("OWCH!!");
        GetComponent<MeshRenderer>().material.color = Color.magenta;
        
        
    }
}
