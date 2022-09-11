/*
* Zach Wilson
* CIS 350 - Assignment 3
* This script controls the removal of objects that go out of bounds (i.e. the dogs and the balls)
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -40;
    private float bottomLimit = -5;

    public HealthSystem healthSystem;

    void Start()
    {
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }


    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            if(!healthSystem.gameOver) { healthSystem.TakeDamage(); } //only take the damage if the game isnt already over
            Destroy(gameObject);
        }

    }
}
