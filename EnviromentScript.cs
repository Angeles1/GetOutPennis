using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentScript : MonoBehaviour {
    public Animator eyesAnimator;
    private float waitTime;


    // Use this for initialization
    void Start () {




        StartCoroutine(Parpadeo());

    }



    IEnumerator Parpadeo()
    {

        while (true)
        {
            waitTime = Random.Range(3,100);
            yield return new WaitForSeconds(waitTime);
            eyesAnimator.SetTrigger("Parpadeo");
        }

    }

}
