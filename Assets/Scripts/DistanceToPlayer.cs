using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceToPlayer : MonoBehaviour
{
    public Transform player;

    public float detectionDistance = 5.0f;

    // Update is called once per frame
    void Update()
    {
        float DistanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (DistanceToPlayer <= detectionDistance)
        {

            Debug.Log("Player is close enough");

        }



    }
}
