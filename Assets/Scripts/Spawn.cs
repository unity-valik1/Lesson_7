using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public static GameObject[] elements = new GameObject[3];
    public GameObject[] startElements;
    Movement robot;

    public GameObject prefabUp;
    public GameObject prefabDown;

    void Start()
    {
        robot = FindObjectOfType<Movement>();
        elements[0] = startElements[0];
        elements[1] = startElements[1];
        elements[2] = startElements[2];
    }

    public void FloorUp()
    {
        for (int i = 0; i < elements.Length; i++)
        {
            elements[i].transform.position = new Vector3(0, elements[i].transform.position.y - 16.5f, 0);
        }
        robot.gameObject.SetActive(false);
        robot.transform.position = new Vector3(robot.transform.position.x, robot.transform.position.y - 16.5f, robot.transform.position.z);

        robot.gameObject.SetActive(true);
    }
    public void FloorDown()
    {
        for (int i = 0; i < elements.Length; i++)
        {
            elements[i].transform.position = new Vector3(0, elements[i].transform.position.y + 16.5f, 0);
        }
        robot.gameObject.SetActive(false);
        robot.transform.position = new Vector3(robot.transform.position.x, robot.transform.position.y + 16.5f, robot.transform.position.z);
        robot.gameObject.SetActive(true);
    }
}
