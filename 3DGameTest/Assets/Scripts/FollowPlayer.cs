using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class FollowPlayer : MonoBehaviour {

    public Transform playerTransform;
    public Vector3 offset;
    
    // Update is called once per frame
    public void Update() {
        transform.position = playerTransform.position + offset;
    }
}
