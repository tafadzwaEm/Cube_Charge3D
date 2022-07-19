using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public Rigidbody rb;
    public float moveLeft = 15f;
    public Transform player;
    // Update is called once per frame
    void Update()
    {
        if (rb.position.z - player.position.z < 200) {
            rb.AddForce(-moveLeft * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
