using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text scoreText;
    void Start()
    {
        scoreText.text = "Score: " + Score.score.ToString();
    }

    void Update()
    {
        
    }

    public void ResetTheGame()
    {
        SceneManager.LoadScene(1);

        Ball.isFall = false;

        Ball ballScript = FindObjectOfType<Ball>();
        if (ballScript != null)
        {
            ballScript.speed = 0f;
            ballScript.Start();
        }
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
