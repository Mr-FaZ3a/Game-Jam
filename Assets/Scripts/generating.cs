using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generating : MonoBehaviour
{
    public List<GameObject> objects;
    bool spawning = false;
    float chance = 0f;
    float time = 6f;
    int n;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update(){
        if (!spawning){
            StartCoroutine(generate());
            spawning = true;
        }
    }
    IEnumerator generate(){
        Instantiate(
            objects[Random.Range(0, 3)],
            new Vector2(
                transform.position.x,
                transform.position.y
            ),
            Quaternion.identity

        );
        while (System.Math.Round(Random.Range(0f, chance)) == 1)
            n++;
        yield return new WaitForSeconds(time);
        time -= 0.1f;
        chance = chance * 1.5f + 0.05f;
        spawning = false;
        for (int i = 0 ; i < n-1 ; i ++)
            Instantiate(
            objects[Random.Range(0, 2)],
            new Vector2(
                transform.position.x,
                transform.position.y
            ),
            Quaternion.identity
        );
        n = 0;

    }
}