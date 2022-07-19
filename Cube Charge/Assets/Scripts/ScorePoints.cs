using UnityEngine;
using UnityEngine.UI;

public class ScorePoints : MonoBehaviour
{
    public Text scorePoints;
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        scorePoints.text = player.position.z.ToString("0");
    }
}
