using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioChooseScript : MonoBehaviour {
    public AudioClip menu;
    public AudioClip gameOver;

    public AudioClip game;
	// Use this for initialization
	void Start () {


    }


    // Update is called once per frame
    void Update () {

        
        
    }

    public void OnLevelWasLoaded(int level)
    {

        if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            this.GetComponent<AudioSource>().clip = game;
        }

        if (SceneManager.GetActiveScene().name == "Fin")
        {
            this.GetComponent<AudioSource>().clip = gameOver;
            this.GetComponent<AudioSource>().Play();

        }

        /*TODO Aun no hay sonido para este ambiente
        if (SceneManager.GetActiveScene().name == "Animacion")
        {
            if (this.GetComponent<AudioSource>().clip != menu)
            {
                this.GetComponent<AudioSource>().clip = menu;
                this.GetComponent<AudioSource>().Play();
            }


        }

    */


        if (SceneManager.GetActiveScene().name == "Inicio")
        {
            if (this.GetComponent<AudioSource>().clip != menu)
            {
                this.GetComponent<AudioSource>().clip = menu;
                this.GetComponent<AudioSource>().Play();
            }
           

        }



    }
}
