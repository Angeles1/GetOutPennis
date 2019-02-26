using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTower : MonoBehaviour {

    public GameObject tower;
    public GameObject site;

    public void OnMouseDown()
    {

   

        site.SetActive(false);
        Instantiate(tower, site.gameObject.GetComponent<Transform>().position, Quaternion.identity);
        this.GetComponent<Transform>().parent.gameObject.SetActive(false);

    }


}
