using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackRotation : MonoBehaviour
{
    public Vector3 positionChange;
    public int howManyFrames;
    private int counter = 0;
    void Update()
    {
        if (howManyFrames > counter)
        {
            transform.position += positionChange;
            counter++;
        }
    }
}
