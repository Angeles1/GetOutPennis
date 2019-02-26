using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Animacion : MonoBehaviour {
    public GameObject barco;
    public GameObject canvas;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if(barco.transform.localScale.x >= 0.75f)
        {
            print("barco ha llegado");
            canvas.SetActive(false);
        }	
	}



}
