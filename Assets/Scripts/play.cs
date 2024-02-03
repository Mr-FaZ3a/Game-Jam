using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class play : MonoBehaviour
{
    Rigidbody2D body;
    int n = 3;
    int speed = 4;
    bool j = false;
    public KeyCode down, up;
    public float force;

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
            body.AddForce(Vector2.up * force);
            j = true;
        }
        if(Input.GetKeyDown(down)){
            body.velocity = new Vector2(body.velocity.x,-4);
        }
    }
    void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.tag == "Ground"){
            j = false;
        }
        if (col.gameObject.tag == "enemy" && n > 0){
            n--;
            Debug.Log("working perFectly");
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(), col.collider);
            Color initcol = GetComponent<SpriteRenderer>().color;
            StartCoroutine(damaging(initcol));
            GetComponent<SpriteRenderer>().color = new Color(initcol.r, initcol.g, initcol.b, 1f);
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
    IEnumerator damaging(Color initcol)
    {
        float time = 0.25f;
        for (int i = 0 ; i < 3 ; i ++ )
        {
            GetComponent<SpriteRenderer>().color = new Color(initcol.r, initcol.g, initcol.b, 0f);
            yield return new WaitForSeconds(time);
            time /= 2;
            GetComponent<SpriteRenderer>().color = new Color(initcol.r, initcol.g, initcol.b, 1f);
            yield return new WaitForSeconds(time);
        }
    }
}