using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class infinity : MonoBehaviour
{
    // public GameObject obj;
    public float speed ;
    float posx, x;
    int i = 0;
    // Start is called before the first frame update
    void Awake(){
    }
    void Start()
    {
        posx = transform.position.x;
        foreach(Transform trans in transform) {x = trans.position.x;i++;}
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0);
        if (Math.Abs(transform.position.x) > (Math.Abs(posx) + Math.Abs(x - posx)/i))
            transform.position = new Vector2(posx, transform.position.y);
    }

    
}
