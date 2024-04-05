using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spacing : MonoBehaviour
{
    public float margin;
    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log("im first");
        int i = 1;
        foreach(Transform trans in transform) trans.position = new Vector2(trans.position.x + i++ * margin, trans.position.y);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
