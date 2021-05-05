using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        gameOver = false;
        restart = false;
        playerDestroyed = false;
        UpdateScore();
    }

    private void Update()
    {
        if(restart){
            if(Input.GetKeyDown(KeyCode.R)){
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                score = 0;
            }
        }
        if(Input.GetKey("escape")){
            Application.Quit();
        }
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
            return;
        }
        playerDestroyed = true;
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
