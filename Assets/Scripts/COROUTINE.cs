using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COROUTINE : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("f")) 
         { 
         StartCoroutine(Fade()); 
         }

    }

    IEnumerator Fade()
    {
        Debug.Log("Fade Enable!!");
        Color c = GetComponent<MeshRenderer>().material.color;
        for (float alpha = 1f; alpha >= 0; alpha -= 0.1f)
        {
            c.a = alpha; GetComponent<MeshRenderer>().material.color = c;
            yield return null;
        }
        
    }
    

    


}

