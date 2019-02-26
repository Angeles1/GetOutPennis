using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : Singleton<Coins>
{
    public static int coins = 0;
    public Text textCoins;
	// Use this for initialization
	void Start () {
        coins = 0;
	}
	
	// Update is called once per frame
	void Update () {
        textCoins.text = coins.ToString();
	}
}
