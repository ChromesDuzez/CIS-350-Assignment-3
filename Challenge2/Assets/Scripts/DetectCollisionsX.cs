/*
* Zach Wilson
* CIS 350 - Assignment 3
* This script controls the collision between the balls and the dog which incraments the score
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private DisplayScore displayScoreScript;
    public HealthSystem healthSystem;
    public bool getHealthOnKill;

    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (getHealthOnKill) { healthSystem.AddHealth(); }
        displayScoreScript.score++;
        Destroy(gameObject);

    }
}
