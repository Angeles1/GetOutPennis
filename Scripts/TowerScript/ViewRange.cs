using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewRange : MonoBehaviour {

    private SpriteRenderer mySpriteRenderer;

    //private Enemy target;

    public GameObject target;
	// Use this for initialization
	void Start () {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
	}
	

    public void Select()
    {
        mySpriteRenderer.enabled = !mySpriteRenderer.enabled;
    }


}
