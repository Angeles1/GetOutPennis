using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnMouseOverScript : MonoBehaviour {

    private GameObject panelInfo;
    private Image image;
    public string NombreInfoPanel;


    private void Start()
    {

        panelInfo = GameObject.Find(NombreInfoPanel);
        image = panelInfo.GetComponent<Image>();

    }

    void OnMouseOver()

    {

        image.enabled = true;

    }

    void OnMouseExit()
    {
        image.enabled = false;

    }



}
