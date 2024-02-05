using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public GameObject Player;
    float speed;
    // Start is called before the first frame update
    void Awake()
    {
    }
    void Start()
    {
        
        speed = Random.Range(2f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0f);
    }
    void OnCollisionEnter2D (Collision2D collision) 
    {
    
        if (collision.gameObject.tag == "enemy" || collision.gameObject.name =="Square" || collision.gameObject.name == "Square1") {
            Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());
        }
        

        
    }
        


}
