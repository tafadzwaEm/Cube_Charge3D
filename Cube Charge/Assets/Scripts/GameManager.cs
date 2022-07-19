using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public ScorePoints scorePoints;
    public bool isGameOver = false;
    public int restartDelay = 3;
    public PlayerCollision playerCollision;
    public int playerTries = 0;
    

    //Game over 
    public void EndGame() {

        if (!isGameOver && !playerCollision.levelWon)
        {
            //Debug.Log("Game Over!!");
            scorePoints.enabled = false;
            isGameOver = true;
            Invoke("Restart", restartDelay);            
        }
        else {          
            Debug.Log("END GAME");            
        }          
    }

    public void Restart() {
        Debug.Log("Restarting Current Level");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void LevelComplete()
    {
        Debug.Log("Level Complete");
        Invoke("NextLevel",restartDelay);
    }
    public void NextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
