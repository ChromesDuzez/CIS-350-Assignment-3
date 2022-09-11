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
