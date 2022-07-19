using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Player object Reference
    public Transform player;
    public Vector3 offset;

    void Update() {
        // make camera follow player
        transform.position = player.position + offset;   
    }

}
