using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infinity : MonoBehaviour
{
    public float speed ;
    float posx, x;
    // Start is called before the first frame update
    void Awake(){
    }
    void Start()
    {
        Debug.Log("im second");
        posx = transform.position.x;
        foreach(Transform trans in transform)
            x = trans.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0);
        if (!(transform.position.x > (posx-x)))
            transform.position = new Vector2(posx, transform.position.y);
    }


}
