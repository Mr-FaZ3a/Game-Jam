using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suicide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-4,0);
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
