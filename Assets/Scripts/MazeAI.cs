using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeAI : MonoBehaviour
{
    GameObject start1;
    public GameObject ball;

    void Start()
    {

    }

    public void Play()
    {
        var newGameCanvas = GameObject.FindGameObjectWithTag("NewGame");
        newGameCanvas.SetActive(false);

        start1 = GameObject.FindGameObjectWithTag("Start1");
        ball.tag = "Ball1";
        Instantiate(ball, start1.transform.position, Quaternion.identity);

        start1 = GameObject.FindGameObjectWithTag("Start2");
        ball.tag = "Ball2";
        Instantiate(ball, start1.transform.position, Quaternion.identity);

        start1 = GameObject.FindGameObjectWithTag("Start3");
        ball.tag = "Ball3";
        Instantiate(ball, start1.transform.position, Quaternion.identity);
    }


    void Update()
    {
        
    }
}
