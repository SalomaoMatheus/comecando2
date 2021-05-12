using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class measureDistanceScript : MonoBehaviour {

    void Start() {
        float distance = getDistanceBetweenTwoPoints(0 , 10, 20, 30);
        Debug.Log(distance);
    }

    float getDistanceBetweenTwoPoints(float x1, float y1, float x2, float y2 ) {
        float dX = x2 - x1;
        float dY = y2 - y2;
        float distanceSquared = dX * dX + dY * dY;
        float distance = Mathf.Sqrt(distanceSquared);
        return distance;
    }
}
