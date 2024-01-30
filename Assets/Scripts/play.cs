using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class play : MonoBehaviour
{
    Rigidbody2D body;
    int n = 3;
    int speed = 4;
    bool j = false;
    public KeyCode down, up;


    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal") * speed;
        body.velocity = new Vector2(move, body.velocity.y   );
        if (Input.GetKeyDown(up) && j == false){
            body.AddForce(Vector2.up * 750);
            j = true;
        }
        if(Input.GetKeyDown(down)){
            body.velocity = new Vector2(body.velocity.y,-4);
        }
    }
    void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.tag == "Ground"){
            j = false;
        }
        if (col.gameObject.tag == "enemy" && n > 0){
            n--;
        }
        else if (col.gameObject.tag == "enemy" && n == 0){
            Time.timeScale = 0f;
        }
    }
    void OnCollisionExit2D(Collision2D col){
        if (col.gameObject.tag == "Ground"){
            j = true;
        }
    }
}