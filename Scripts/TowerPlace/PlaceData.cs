using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceData : MonoBehaviour {

    public GameObject buyMenu;
    public AudioSource clickTower;
    public AudioClip clip;
	// Use this for initialization
	void Start () {
        buyMenu.SetActive(false);

    }
	
    private void OnMouseDown()
    {

            this.buyMenu.SetActive(true);
            clickTower.PlayOneShot(clip);

 

    }


    void OnMouseExit()
    {
        this.buyMenu.SetActive(false);
    }
}
