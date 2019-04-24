using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitMaze : MonoBehaviour
{
    public GameObject ball;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball1"))
        {
            Destroy(other.gameObject);
            GameObject start = GameObject.FindGameObjectWithTag("Start1");
            Instantiate(ball, start.transform.position, Quaternion.identity);
        }
        else if (other.name == "Ball2")
        {
            Destroy(other.gameObject);
            GameObject start = GameObject.FindGameObjectWithTag("Start2");
            Instantiate(ball, start.transform.position, Quaternion.identity);
        }
        else if (other.name == "Ball3")
        {
            Destroy(other.gameObject);
            GameObject start = GameObject.FindGameObjectWithTag("Start3");
            Instantiate(ball, start.transform.position, Quaternion.identity);
        }
    }
}
