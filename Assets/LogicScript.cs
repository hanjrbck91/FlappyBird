using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    //Restart game
    public void restartGame()
    {
        Time.timeScale = 1;
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //GameOver
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

  

    
}
