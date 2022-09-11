/*
* Zach Wilson
* CIS 350 - Assignment 3
* This script controls the player input for spawning the food that gets thrown at the animals
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach this script to the player
public class ShootPrefab : MonoBehaviour
{
    //Set thsi reference in the inspector
    public GameObject prefabToShoot;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabToShoot, transform.position, prefabToShoot.transform.rotation);
        }
    }
}
