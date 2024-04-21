using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 30f;
    public string rotationVector = "x";

    void Update()
    {
        if (rotationVector == "x")
        {
            transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0, Space.Self);
        }
        else if (rotationVector == "y")
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0, Space.Self);
        }
        else if (rotationVector == "z")
        {
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime, Space.Self);
        }
        
    }
}
