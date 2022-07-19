using UnityEngine;
using UnityEngine.UI;

public class WinningText : MonoBehaviour
{
    public Text winningText;

    // Update is called once per frame
    public void WUpdate()
    {
        winningText.text = "LEVEL\nCOMPLETE";
    }
}
