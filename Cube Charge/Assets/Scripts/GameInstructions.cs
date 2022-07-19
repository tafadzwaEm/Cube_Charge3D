using UnityEngine;

public class GameInstructions : MonoBehaviour
{
    public GameObject instructionsTab;

    public void openInstructions()
    {
         instructionsTab.SetActive(true);   
    }
}
