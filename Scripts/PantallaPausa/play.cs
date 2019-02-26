using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class play : MonoBehaviour {

    public Sprite pause;
    public Sprite slower;

    public Button slow;
    public Button botonpausado;


    public void OnMouseDown()
    {
        if(slow.GetComponent<Image>().sprite != slower)
        {
            botonpausado.GetComponent<Image>().sprite = pause;
            Time.timeScale = 1;
            this.gameObject.GetComponent<Transform>().parent.gameObject.GetComponent<Transform>().parent.gameObject.SetActive(false);
        }
        else
        {
            botonpausado.GetComponent<Image>().sprite = pause;
            Time.timeScale = 4;
            this.gameObject.GetComponent<Transform>().parent.gameObject.GetComponent<Transform>().parent.gameObject.SetActive(false);
        }
 
    }
}
