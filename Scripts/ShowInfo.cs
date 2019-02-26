using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowInfo : MonoBehaviour {
    public GameObject panelInfo;
    private Image image;
    public GameObject panelCompra;
    private Image imageCompra;

    // Use this for initialization
    void Start () {
        panelInfo = GameObject.Find("PanelInfo");
        image = panelInfo.GetComponent<Image>();

        panelCompra = GameObject.Find("PanelCompra");
        imageCompra = panelCompra.GetComponent<Image>();

    }

    public void MostrarInfo()

    {
        imageCompra.enabled = true;
        image.enabled = true;

    }

    void CerrarInfo()
    {
        imageCompra.enabled = false;

        image.enabled = false;

    }
}
