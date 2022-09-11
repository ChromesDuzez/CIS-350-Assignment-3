/*
* Zach Wilson
* CIS 350 - Assignment 3
* This script controls the player input for spawning the dogs
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public HealthSystem healthSystem;
    public float coolDownTime;
    private bool cooldown = false;

    // Start is called before the first frame update
    void Start()
    {
        if (coolDownTime < 0) { coolDownTime = 0.5f; }
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && !healthSystem.gameOver && !cooldown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            OnButtonDown();
        }
    }

    void OnButtonDown()
    {
        if (cooldown == false)
        {
            Invoke("ResetCooldown", coolDownTime);
            cooldown = true;
        }
    }

    void ResetCooldown()
    {
        cooldown = false;
    }
}
