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
    void Start()
    {
        posx = transform.position.x;
        initpos = obj.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (obj.transform.position.x > 0f){
            transform.position = new Vector2(transform.position.x - speed, transform.position.y);
            obj.transform.position = new Vector2(obj.transform.position.x - speed, obj.transform.position.y);
        }
        else{
            transform.position = new Vector2(posx, transform.position.y);
            obj.transform.position = new Vector2(initpos, obj.transform.position.y  );
        }
    }

}
