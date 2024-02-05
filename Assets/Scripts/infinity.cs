using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infinity : MonoBehaviour
{
    public GameObject obj;
    public float speed ;
    float initpos;
    float posx;
    // Start is called before the first frame update
    void Awake(){
        Physics2D.IgnoreLayerCollision(6,7);
    }
    void Start()
    {
        posx = transform.position.x;
        initpos = obj.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0);
        obj.GetComponent<Rigidbody2D>().velocity = new Vector2(- speed , 0);
        if (!(obj.transform.position.x > 0f)){
            transform.position = new Vector2(posx, transform.position.y);
            obj.transform.position = new Vector2(initpos, obj.transform.position.y);
        }
    }


}
