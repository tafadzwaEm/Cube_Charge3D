using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBall : MonoBehaviour
{
    public float forwardForce = 2000f;
    public Rigidbody rb;

    // Update is called once per frame
    void FixedUpdate()
    {
       rb.AddForce(0,0,-forwardForce * Time.deltaTime,ForceMode.VelocityChange);
    }
}
