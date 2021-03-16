using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    // Start is called before the first frame update
    // ReSharper disable once ArrangeTypeMemberModifiers
    void Start() {
        Debug.Log("hello work");
    }

    // Update is called once per frame
    // ReSharper disable once ArrangeTypeMemberModifiers
    void FixedUpdate() {
        rb.AddForce(0, 0, Time.deltaTime * 800);
    }
}
