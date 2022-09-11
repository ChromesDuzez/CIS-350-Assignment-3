/*
* Zach Wilson
* CIS 350 - Assignment 3
* This controls the movement of the animals and the food so they move forward
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
