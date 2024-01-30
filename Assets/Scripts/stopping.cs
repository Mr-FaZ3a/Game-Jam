using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopping : MonoBehaviour
{
    bool exit = false;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (exit)
            player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }
    

}
