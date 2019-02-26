using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectile : MonoBehaviour {

    public GameObject projectile;
    public float projectileCoolDown = 3;
    public int projectileDamage = 2;

    List<GameObject> listOfTargets = new List<GameObject>();


    private void Start()
    {
        StartCoroutine(Attack());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Enemy"  && !collision.gameObject.GetComponent<EnemyType>().inmunities.tirachinas)
        {   
                listOfTargets.Add(collision.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            listOfTargets.Remove(collision.gameObject);
        }
    }

    IEnumerator Attack()
    {
        while (true)
        {
            if (listOfTargets.Count > 0)
            {
                GameObject target = listOfTargets[0];
                Vector3 dir = target.transform.position - gameObject.transform.position;
                float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

                GameObject newProjectile = Instantiate(projectile, gameObject.transform.position, Quaternion.AngleAxis(angle, Vector3.forward));
                newProjectile.GetComponent<Projectile>().target = target;
                newProjectile.GetComponent<Projectile>().dañoProjectil = projectileDamage;
                print(newProjectile.GetComponent<Projectile>().dañoProjectil);
                yield return new WaitForSeconds(projectileCoolDown);
            }
            yield return null;
                 
        }
       
    }


}
