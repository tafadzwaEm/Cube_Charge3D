using UnityEngine;

public class CloseInstructions : MonoBehaviour
{
    public GameObject instructionsTab;
    public void closeInstructions()
    {
        instructionsTab = GameObject.Find("InstructionsTab");
        instructionsTab.SetActive(false);
    }
}
