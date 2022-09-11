/*
* Zach Wilson
* CIS 350 - Assignment 3
* This script was given to me by challenge 2 but it controls the movement of the dogs and the balls so they move forward
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
