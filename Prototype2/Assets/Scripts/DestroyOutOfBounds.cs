/*
* Zach Wilson
* CIS 350 - Assignment 3
* This script controls the removal of objects that go out of bounds (i.e. the food and the animals)
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 20;
    public float bottomBound = -10;

    public HealthSystem healthSystem;

    void Start()
    {
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        //if food goes out of bounds
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        
        //if animals go out of bounds
        if(transform.position.z < bottomBound)
        {
            //Debug.Log("Game Over!");
            healthSystem.TakeDamage();
            Destroy(gameObject);
        }
    }
}
