using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class TarainGenerator : MonoBehaviour {

    public Transform pfObstacle;

    private const float distanceFromStart = 20f;
    
    private const float maxSpace = 20f;
    private const float minSpace = 5f;
    private const float spaceDrop = 0.1f;
    
    // Start is called before the first frame update
    private void Start() {
        //spawn obstacle
        madeRandomLevel(100);
    }

    private void madeRandomLevel(int block_count) {
        float space = maxSpace;
        
        for (int i = 0; i < block_count; i++) {
            float size = pfObstacle.localScale.x;
            float x = Random.Range(-6f + size/2, 6f - size/2);
            
            pfObstacle.position = new Vector3(x, 1, i*space + distanceFromStart);
            Instantiate(pfObstacle);

            if (space - spaceDrop > minSpace)
                space -= spaceDrop;
        }
        
    }
    
    // Update is called once per frame
    private void Update() {
       
    }
    
    
}
