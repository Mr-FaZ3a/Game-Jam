using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class Music : MonoBehaviour {
    bool touch = false;
    public List<AudioClip> sounds;
    // Use this for initialization
    void Start () {
        AudioSource.PlayClipAtPoint (sounds[0], transform.position);

    }
   
    // Update is called once per frame
    void Update () {
        
    }
    void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.name == "Hit"){
            AudioSource.PlayClipAtPoint(sounds[1], transform.position);
            touch = true;
        }
    }
    void OnTriggerExit2D(Collider2D col){
        if (col.gameObject.name == "Trigger" && !touch)
            AudioSource.PlayClipAtPoint(sounds[2], transform.position);
    }
}