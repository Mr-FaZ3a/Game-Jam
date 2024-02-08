using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Damaging : MonoBehaviour
{
    GameObject Player;
    Color initCol ;
    int n = 6;
    // Start is called before the first frame update
    void Awake(){
        Player = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update(){
        
    }
    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "enemy" && n > 0){
            initCol = Player.GetComponent<SpriteRenderer>().color;
            StartCoroutine(damaging());
            Player.GetComponent<SpriteRenderer>().color = new Color (initCol.r, initCol.b, initCol.g, 1f);
            n --;
        }
        else if (col.gameObject.tag == "enemy"){
            Time.timeScale = 0f;
        }
    }
    IEnumerator damaging(){
        float time = 0.25f;
        for (int i = 0 ; i < 3 ; i ++){
            Player.GetComponent<SpriteRenderer>().color = new Color(initCol.r, initCol.g, initCol.b, 0f);
            yield return new WaitForSeconds(time);
            time /= 2;
            Player.GetComponent<SpriteRenderer>().color = new Color(initCol.r, initCol.g, initCol.b, 1f);
            yield return new WaitForSeconds(time);
        }

    }

}
