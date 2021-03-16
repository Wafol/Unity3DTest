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

    // Start is called before the first frame update
    // ReSharper disable once ArrangeTypeMemberModifiers
    public void Start() {
        Debug.Log("hello work");
        //rb.AddForce(0, 0, 90);
    }

    public void Update() {
        //input
        goRight = Input.GetKey("d");
        goLeft = Input.GetKey("a");
    }

    // Update is called once per frame
    // ReSharper disable once ArrangeTypeMemberModifiers
    public void FixedUpdate() {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (goRight)
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);

        if (goLeft)
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
    }
}
