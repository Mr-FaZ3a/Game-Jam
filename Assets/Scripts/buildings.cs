using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildings : MonoBehaviour
{
    public List<GameObject> objects;
    public float speed;
    int n = 0;
    private Vector2 initpos;

    // Start is called before the first frame update
    void Awake()
    {
        initpos = objects[0].transform.position;
    }
    void Start(){
        foreach(GameObject i in objects)
            i.GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0);
    }
    void OnTriggerExit2D(Collider2D col){
        if (col.gameObject.tag == "Buildings"){
            col.gameObject.transform.position = initpos;
            n++;
        }
    }
}
