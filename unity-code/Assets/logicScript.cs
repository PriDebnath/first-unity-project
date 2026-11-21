
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{
    public int score;
    public int highScore;

    public Text scoreText;
    public Text highScoreText;

    public GameObject gameOverObject;

    void Start()
    {
        // Load saved high score
        highScore = PlayerPrefs.GetInt("HighScore", 0);

        highScoreText.text = "Best: " + highScore;
    }

    [ContextMenu("addScore")]
    public void addScrore()
    {
        score++;

        scoreText.text = score.ToString();

        // Update high score
        if (score > highScore)
        {
            highScore = score;

            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();

            highScoreText.text = "Best: " + highScore;
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        Debug.Log("game over called");
        gameOverObject.SetActive(true);
    }
}
