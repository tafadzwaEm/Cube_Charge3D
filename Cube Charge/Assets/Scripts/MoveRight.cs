using UnityEngine;

public class MoveRight : MonoBehaviour
{

    public Rigidbody rb;
    public float moveRight = 15f;
    public Transform player;
    // Update is called once per frame
    void Update()
    {
        if (rb.position.z - player.position.z < 200)
        {
            rb.AddForce(moveRight * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
