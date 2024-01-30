using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    float speed;
    // Start is called before the first frame update
    
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
    
        if (collision.gameObject.tag == "enemy" || collision.gameObject.name == "Player" ||collision.gameObject.name =="Square" || collision.gameObject.name == "Square1") {
            Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());
        }

        // if (collision.gameObject.name == "Player"){
        //     iscolled = true;
        // } 
        // if (collision.gameObject.tag == "Player" )
        // {
        //     Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(),GetComponent<Collider2D>(), true);
        //     StartCoroutine(damaging(collision));
        //     Color initcol = collision.gameObject.GetComponent<SpriteRenderer>().color;

        //     collision.gameObject.GetComponent<SpriteRenderer>().color = new Color(initcol.r, initcol.g, initcol.b, 1f);
        //     Debug.Log(collision.gameObject.name)
        // }
    }
    void OnTriggerEnter2D(Collider2D col )
    {
        if (col.gameObject.name == "Player"){
            Physics2D.IgnoreCollision(col.GetComponent<Collider2D>(),GetComponent<Collider2D>());
            StartCoroutine(damaging(col));
            Color initcol = col.gameObject.GetComponent<SpriteRenderer>().color;

            col.gameObject.GetComponent<SpriteRenderer>().color = new Color(initcol.r, initcol.g, initcol.b, 1f);
            
        }
    }
    IEnumerator damaging(Collider2D col)
    {
        Color initcol = col.gameObject.GetComponent<SpriteRenderer>().color;
        float time = 0.25f;
        for (int i = 0 ; i < 3 ; i ++ )
        {
            col.gameObject.GetComponent<SpriteRenderer>().color = new Color(initcol.r, initcol.g, initcol.b, 0f); 
            yield return new WaitForSeconds(time);
            col.gameObject.GetComponent<SpriteRenderer>().color = new Color(initcol.r, initcol.g, initcol.b, 1f);
            time /= 2f;
            yield return new WaitForSeconds(time);
        }
    }
        


}
