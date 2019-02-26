using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    public float speed = 3.5f;
    public  GameObject target = null;
    public int dañoProjectil = 2; // Cantidad de daño que produce al enemigo



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(target != null)
        {
           this.transform.position = Vector3.MoveTowards(this.transform.position, target.transform.position + new Vector3(0, 0, 0), speed);
        }
	}


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && collision.gameObject == target)
        {
            Destroy(gameObject);
            GameObject enemigo = collision.gameObject;
            EnemyType DatosEnemigo = (EnemyType)enemigo.GetComponent(typeof(EnemyType));
            DatosEnemigo.PerderVida(dañoProjectil, gameObject.name);
        }

    }
}
