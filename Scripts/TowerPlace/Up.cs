using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up : MonoBehaviour {

    public GameObject tower;
    public GameObject range;
    int level = 1;

    private void OnMouseDown()
    {
        print("SUBE DE NIVEL: " + tower.name + "  nivel  " + level);

        if (tower.name == "TirachinasPrefab(Clone)")
        {
            if (level == 1)
            {
                range.GetComponent<ShootProjectile>().projectileDamage = 3;
                level++;
            } else if(level == 2)
            {
                range.GetComponent<ShootProjectile>().projectileDamage = 4;
                range.GetComponent<ShootProjectile>().projectileCoolDown = 2;
                level++;
            }
        } else if(tower.name == "DiuPrefab(clone)")
        {
            if (level == 1)
            {
                range.GetComponent<DiuAttack>().damage = 5;
            }
            else if (level == 2) {
                
            }
            
        }
    }
}
