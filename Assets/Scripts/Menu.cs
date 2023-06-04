using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayButton()
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

    public void QuitButton()
    {
        Application.Quit();
    }
}
