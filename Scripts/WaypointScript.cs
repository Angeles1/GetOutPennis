using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointScript : MonoBehaviour {

    public static Transform[] pointsOne;
    public static Transform[] pointsTwo;

    // Use this for initialization
    void Awake () {

        if(gameObject.name == "WayOne")
        {
            pointsOne = new Transform[transform.childCount];
            for (int i = 0; i < pointsOne.Length; i++)
            {
                pointsOne[i] = transform.GetChild(i);
            }
        }

        if (gameObject.name == "WayTwo")
        {
            pointsTwo = new Transform[transform.childCount];
            for (int i = 0; i < pointsTwo.Length; i++)
            {
                pointsTwo[i] = transform.GetChild(i);
            }
        }

    }
	

}
