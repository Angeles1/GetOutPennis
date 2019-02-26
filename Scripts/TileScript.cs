using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TileScript : MonoBehaviour {

    public bool IsEmpty { get; private set; }

    private ViewRange myTower;

    BoxCollider2D m_Collider;


    // Use this for initialization
    void Start () {
        IsEmpty = true;
        m_Collider = gameObject.GetComponent<BoxCollider2D>();

    }

    // Update is called once per frame
    void Update () {
		
	}

    
    private void OnMouseOver()
    {
        if (!EventSystem.current.IsPointerOverGameObject() && GameManager.Instance.ClickedBtn != null)
        {
            if (IsEmpty)
            {
                if (Input.GetMouseButtonDown(0) && Coins.coins >= 2)// COMPROBAR QUE HAY MONEDAS
                {
                    PlaceTower();
                }
            }   
            
        }
        else if(!EventSystem.current.IsPointerOverGameObject() && GameManager.Instance.ClickedBtn == null && Input.GetMouseButtonDown(0))
        {
            if (myTower != null)
            {
                GameManager.Instance.SelectTower(myTower);

            }
            else
            {
                print("puedo vender torre");
                GameManager.Instance.DeselectTower();
            }
        }
    }

    private void PlaceTower()
    {
        
        GameObject tower = Instantiate(GameManager.Instance.ClickedBtn.TowerPrefab, transform.position, Quaternion.identity);
        tower.GetComponent<SpriteRenderer>().sortingOrder = (int)transform.position.y;
        tower.transform.SetParent(transform);
        this.myTower = tower.transform.GetChild(0).GetComponent<ViewRange>();
        m_Collider.enabled = false;
        IsEmpty = false;
        HoverScript.Instance.Deactivate();
        
        GameManager.Instance.BuyTower(2); //Comprar una torre gastando 2 monedas
    }




    private void DesplaceTower()
    {



        print("VENDER TORRE");
        Destroy(myTower);
        IsEmpty = true;

        GameManager.Instance.SellTower(1); //Vender una torre ganando 1 moneda
    }
}
