using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject gameOverObject;

    [ContextMenu("addScrore")]
  public  void addScrore(){
score = score + 1;
scoreText.text = score.ToString();
    }

    public void restartGame(){
SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    // // Start is called once before the first execution of Update after the MonoBehaviour is created
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

   public void gameOver(){
      Debug.Log("game over caled");
        gameOverObject.SetActive(true);
    }
}
