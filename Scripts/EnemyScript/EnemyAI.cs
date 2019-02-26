using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {
    //public float speed = 1f;

    private Transform target;
    private int wavepointIndex = 0;
    public Transform generator;
    public Sprite newSprite;
    private float speed;


    private void Start()
    {
        generator = this.gameObject.transform.parent;
        if(generator.name == "GeneratorDown")
        {
            target = WaypointScript.pointsOne[0];

        }
        else
        {
            target = WaypointScript.pointsTwo[0];

        }
    }

    private void Update()
    {
        speed = GetComponent<EnemyType>().velocidad;

        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized* speed * Time.deltaTime, Space.World);

        if(Vector3.Distance(transform.position,target.position)<= 0.4f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        

        if (generator.name == "GeneratorDown")
        {
            if(wavepointIndex == WaypointScript.pointsOne.Length - 2)
            {
                GetComponent<Animator>().enabled = false;
                this.GetComponent<SpriteRenderer>().sprite = newSprite;
                GetComponent<EnemyType>().velocidad += 2f;
            }


            if (wavepointIndex >= WaypointScript.pointsOne.Length - 1)
            {
                Destroy(gameObject);
            }
            else
            {
                wavepointIndex++;
                target = WaypointScript.pointsOne[wavepointIndex];

            }

        }
        else
        {
            if (wavepointIndex == WaypointScript.pointsTwo.Length - 2)
            {
                GetComponent<Animator>().enabled = false;

                GetComponent<SpriteRenderer>().sprite = newSprite;
                GetComponent<EnemyType>().velocidad += 2f;

            }

            if (wavepointIndex >= WaypointScript.pointsTwo.Length - 1)
            {
                Destroy(gameObject);
            }
            else
            {
                wavepointIndex++;
                target = WaypointScript.pointsTwo[wavepointIndex];

            }

        }


    }
}
