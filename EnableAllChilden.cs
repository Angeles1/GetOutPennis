using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableAllChilden : MonoBehaviour {

    public GameObject children;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.GetComponent<Image>().enabled) {
            EnableChildren();
        }
        else
        {
            DisableChildren();
        }
	}

    public void EnableChildren()
    {
        children.SetActive(true);
    }


    public void DisableChildren()
    {
        children.SetActive(false);
    }

}
