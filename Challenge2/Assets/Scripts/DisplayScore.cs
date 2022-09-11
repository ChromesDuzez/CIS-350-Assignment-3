/*
* Zach Wilson
* CIS 350 - Assignment 3
* This script controls the scoreboard and also the win condition game over screen
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayScore : MonoBehaviour
{
    public Text textbox;
    public int score = 0;
    public int winCondition;
    public HealthSystem healthSystem;
    public GameObject gameOverWinText;

    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<Text>();
        if (winCondition <= 0) { winCondition = 5; } //check to make sure the win condition is valid upon start
        gameOverWinText.SetActive(false);
        textbox.text = "Score: 0";
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;

        if(score >= winCondition)
        {
            healthSystem.gameOver = true;
            gameOverWinText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
