using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    public int lives = 3;
    
    public Text restartText;
    public Text gameoverText;
    
    private bool gameOver;
    private bool restart;
    private bool playerDestroyed;

    private void Start()
    {
        UpdateScore();
    }
    
    private void UpdateScore()
    {
        scoreText.text = lives + ":" + score;
    }

    public void RemoveLife()
    {
        lives--;
        UpdateScore();
        if (lives == 0)
        {
            GameOver();
            playerDestroyed = true;
        }
    }

    public void AddScore()
    {
        score++;
        UpdateScore();
    }
    
    public void GameOver(){
        gameoverText.text = "Game Over!";
        gameOver = true;
        lives = 3;
    }
}
