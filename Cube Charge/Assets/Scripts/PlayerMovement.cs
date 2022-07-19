using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
   // public GameManager gameManager;
    public Transform player;

    public float forwardForce = 2000f;
    public float sidewaysForce = 120f;
    
    // Modified the function to FixedUpdate as we will be playing with physics of game
    void Update()
    {
        // adding forward force to the rigid body
        rb.AddForce(0,0,forwardForce * Time.deltaTime);

        // move player sideways
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime,0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        

        if (player.position.y < -1) {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
    
}
