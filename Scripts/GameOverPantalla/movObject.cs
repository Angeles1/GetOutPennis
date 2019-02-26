using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movObject : MonoBehaviour {

    public GameObject algo;
    double i;

	void Start () {
        i = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if(algo.GetComponent<Transform>().position.x < 14)
        {
            algo.GetComponent<Transform>().position = new Vector3(algo.GetComponent<Transform>().position.x + (float)i, algo.GetComponent<Transform>().position.y, algo.GetComponent<Transform>().position.z);
            i = i + 0.0001;
        }
        else { Destroy(algo); }
        
        
	}
}
