using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject gameOverCanvas;

    public Text scoreText;
    public Text menuYourScoreText;
    public Text menuHighScoreText;
    public int score;
    public bool gameOver;

    private void Awake(){
        if (instance == null){
            instance = this;
        }
    }

    private void Start(){
        menuHighScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void IncrementScore(){
        if (!gameOver){
            score++;
            scoreText.text = score.ToString();
            menuYourScoreText.text = score.ToString();

            if(score > PlayerPrefs.GetInt("HighScore",0)){
                PlayerPrefs.SetInt("HighScore", score);
                menuHighScoreText.text = score.ToString();     
            }
        }
    }

    public void RestartButton(){
        SceneManager.LoadScene(0);
    }

    public void ExitButton(){
        Application.Quit();
    }
}
