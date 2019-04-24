using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour
{
    public float treshhold = 0.2f;
    private Vector3 currentRotation;

    void FixedUpdate()
    {
        currentRotation = GetComponent<Transform>().eulerAngles;

        print(currentRotation);

        if (Input.GetAxis("Horizontal") > treshhold) 
            //&& (currentRotation.z <= 10 || currentRotation.z >= 348))
        {
            transform.Rotate(0, 0, 1);
        }

        if (Input.GetAxis("Horizontal") < (-1 * treshhold)) 
            //&& (currentRotation.z >= 349 || currentRotation.z <= 11))
        {
            transform.Rotate(0, 0, -1);
        }

        if (Input.GetAxis("Vertical") > treshhold) 
            //&& (currentRotation.x <= 10 || currentRotation.x >= 348))
        {
            transform.Rotate(1, 0, 0);
        }

        if (Input.GetAxis("Vertical") < (-1 * treshhold))
            //&& (currentRotation.x >= 349 || currentRotation.x <= 11))
        {
            transform.Rotate(-1, 0, 0);
        }
    }
}
