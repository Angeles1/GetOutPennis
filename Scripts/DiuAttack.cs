using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiuAttack : MonoBehaviour {

    public int cooldown = 3;
    public int damage;

    // Use this for initialization
    void Start () {
        StartCoroutine(Attack());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private IEnumerator Attack()
    {
        while (true)
        {
            Collider2D[] hitColliders = Physics2D.OverlapCircleAll(gameObject.transform.position, 2f);
            int i = 0;
            while (i < hitColliders.Length)
            {

                if (hitColliders[i].gameObject.tag == "Enemy" && !hitColliders[i].gameObject.GetComponent<EnemyType>().inmunities.diu)
                {
                    GameObject enemigo = hitColliders[i].gameObject;
                    EnemyType DatosEnemigo = (EnemyType)enemigo.GetComponent(typeof(EnemyType));
                    DatosEnemigo.PerderVida(damage, "Diu Prefab(clone)");

                }
                i++;
            }
            yield return new WaitForSeconds(cooldown);
        }
    }
}
