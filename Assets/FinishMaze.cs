using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishMaze : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        var rb = other.gameObject.GetComponent<Rigidbody>();
        rb.useGravity = false;
    }
}
