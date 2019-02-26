using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager> {

    public TowerBtn ClickedBtn { get; private set; }
    private ViewRange selectedTower;
    public static int oleada = 1;
    public static int numberOfWave;

    // Use this for initialization
    void Start () {
        numberOfWave = 1;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PickTower(TowerBtn towerBtn)
    {
        ClickedBtn = towerBtn;
        if(Coins.coins >= 2)
        {
            HoverScript.Instance.Activate(towerBtn.Sprite);
        }
    }

    public void BuyTower(int precio)
    {

        Coins.coins -= precio;
        ClickedBtn = null;
    }


    public void SellTower(int precio)
    {

        Coins.coins += precio;

        ClickedBtn = null;
    }


    public void SelectTower(ViewRange tower)
    {
        if(selectedTower != null)
        {
            selectedTower.Select();
        }
        
        selectedTower = tower;
        selectedTower.Select();
    }

    public void DeselectTower()
    {
        if(selectedTower != null)
        {
            selectedTower.Select();
        }
        selectedTower = null;
    }
}
