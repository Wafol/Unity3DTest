using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 500f;
    public float sidewaysForce = 1000f;

    private bool goLeft;
    private bool goRight;
    
    private void Update() {
        //input
        goRight = Input.GetKey("d");
        goLeft = Input.GetKey("a");
    }

    // Update is called once per frame
    private void FixedUpdate() {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (goRight)
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);

        if (goLeft)
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
    }
}
