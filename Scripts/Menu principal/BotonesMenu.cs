using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BotonesMenu : MonoBehaviour {
    public Sprite[] sprites;
    public Sprite pause;
    public Sprite play;
    public Sprite acelerar;


    public GameObject pausa;
	
	// Update is called once per frame
	void Update () {
        if(Time.timeScale != 0)
        {
           GameObject.Find("Pausar").GetComponent<Image>().sprite = pause;
           GameObject.Find("Acelerar").GetComponent<Image>().sprite = play;

        }
        if (Time.timeScale == 4)
        {
            GameObject.Find("Acelerar").GetComponent<Image>().sprite = play;

        }
        if (Time.timeScale == 1)
        {
            GameObject.Find("Acelerar").GetComponent<Image>().sprite = acelerar;

        }
    }

    public void CambiarEscena(string escena)
    {
        SceneManager.LoadScene(escena);
    }

    public void Salir()
    {
        Application.Quit();
    }


    public void CambiarVelocidad()
    {

        if (Time.timeScale == 1f)
        {
            gameObject.GetComponent<Image>().sprite = sprites[0];

            Time.timeScale = 4f;
        }
        else if(Time.timeScale == 4f)
        {
            gameObject.GetComponent<Image>().sprite = sprites[1];
            Time.timeScale =1f;

        }

    }


    public void Pausar()
    {
        if (Time.timeScale != 0)
        {
            gameObject.GetComponent<Image>().sprite = sprites[1];
            Time.timeScale = 0;
            pausa.SetActive(true);
        }
        else
        {
            gameObject.GetComponent<Image>().sprite = sprites[0];
            Time.timeScale = 1;
        }

    } 
}
