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
        GetComponent<Rigidbody2D>().velocity = new Vector2(- speed, 0f);
        Physics2D.IgnoreLayerCollision(8, 8);
        Physics2D.IgnoreLayerCollision(8, 10);
    }

    // Update is called once per frame
    void Update()
    {
    }


}
