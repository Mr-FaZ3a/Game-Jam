using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infinity : MonoBehaviour
{
    // public GameObject obj;
    public float speed ;
    float posx;
    // Start is called before the first frame update
    void Awake(){
    }
    void Start()
    {
        posx = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0);
        if (!(transform.position.x > -17.1659f))
            transform.position = new Vector2(posx, transform.position.y);
    }


}
