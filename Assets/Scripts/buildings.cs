using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildings : MonoBehaviour
{
    public List<GameObject> objects;
    public float speed;

    private List<Vector3> initPoses;

    // Start is called before the first frame update
    void Start()
    {
        // Save the initial positions of all buildings
        initPoses = new List<Vector3>();
        foreach (GameObject obj in objects)
        {
            initPoses.Add(obj.transform.position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Move all buildings to the left
        for (int i = 0; i < objects.Count; i++)
        {
            objects[i].transform.position = new Vector3(objects[i].transform.position.x - speed * Time.deltaTime, objects[i].transform.position.y, objects[i].transform.position.z);
        }

        // Check if the first building is out of the camera's view
        if (objects[0].transform.position.x < Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x)
        {
            // Move the first building to the last initial position
            objects[0].transform.position = initPoses[objects.Count - 1];

            // Rotate the list to maintain the order of initial positions
            objects.RotateList();
        }
    }
}

public static class ListExtensions
{
    // Extension method to rotate a list to the left
    public static void RotateList<T>(this List<T> list)
    {
        T temp = list[0];
        list.RemoveAt(0);
        list.Add(temp);
    }
}
