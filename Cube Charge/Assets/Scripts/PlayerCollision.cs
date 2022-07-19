using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //public GameManager gameManager;
    public PlayerMovement playerMovement;
    public WinningText winningText;
    public FollowPlayer followPlayer;
    public ScorePoints scorePoints;
    public bool levelWon = false;

    public void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("Collided with Obstacle!!");
            playerMovement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

        if (collisionInfo.collider.tag == "LevelComplete")
        {
            Debug.Log("LevelComplete Triggered...");
            scorePoints.enabled = false;
            levelWon = true;
            winningText.WUpdate();
            FindObjectOfType<GameManager>().LevelComplete();
        }
    }
}
