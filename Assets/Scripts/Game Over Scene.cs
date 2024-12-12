using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScene : MonoBehaviour
{
    public int lives = 3;

    void Update()
    {
        if (lives <= 0)
        {
            LoadGameOverScene();
        }
    }

    public void LoseLife()
    {
        lives--;
    }

    void LoadGameOverScene()
    {
        SceneManager.LoadScene("GameOverScene");
    }
}
