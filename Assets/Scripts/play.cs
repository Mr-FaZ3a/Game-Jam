using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class play : MonoBehaviour
{
    Rigidbody2D body;
     
    bool j = false;
    public KeyCode down, up;
    public float force,speed ;

    // Start is called before the first frame update
    void Awake()
    {
        Physics2D.IgnoreLayerCollision(8,9);

    }
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        GetComponent<Rigidbody2D>().velocity = new Vector2(move, GetComponent<Rigidbody2D>().velocity.y);
        transform.Translate(new Vector2(move,0));
        if (Input.GetKeyDown(up) && j == false){
            body.AddForce(Vector2.up * force);
            j = true;
        }
        if(Input.GetKeyDown(down)){
            body.velocity = new Vector2(body.velocity.x,-4);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground" && j){
            Debug.Log("hello world");
            j = false;
        }

    }
    
}