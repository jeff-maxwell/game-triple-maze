using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishMaze : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Destroy(other);

        MazeAI.ballCount--;

        if (MazeAI.ballCount == 0)
        {
            var maze = GameObject.FindGameObjectWithTag("Maze");
            maze.GetComponent<MazeAI>().ShowWelcome(true);
        }
    }
}
