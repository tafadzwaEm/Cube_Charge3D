using UnityEngine;

public class LevelComplete : MonoBehaviour
{
   public WinningText winningText;
  // public GameManager gameManager;

    
    public void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "LevelComplete")
        {
            winningText.WUpdate();
        }
    }
}
