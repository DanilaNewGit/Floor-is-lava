using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRotate : MonoBehaviour
{
    public Vector3 rotateChange;
    public int howManyFrames;
    private int counter;

    void Update()
    {
        if(howManyFrames > counter)
        {
            transform.Rotate(rotateChange);
            counter++;
        }
    }
}
