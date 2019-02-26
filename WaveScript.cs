using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveScript : MonoBehaviour
{

    public Sprite[] sprites;
    public float time = 0.5f;
    public EnemiesGeneratorScript[] enemyGenerators;
    public int actualWave;
    public Text WaveText;
    public AudioSource gameAudio;
    public AudioSource countAudio;


    public int indexSprite = 0;
    // Use this for initialization
    void Start()
    {
        actualWave = GameManager.numberOfWave;
        StartCoroutine(WaveStart());


    }


    void Update()
    {
        ///TESTING
       /* if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(WaveStart());

        }
        */
    }




    IEnumerator WaveStart()
    {
        for (int i = 0; i < sprites.Length; i++)
        {

            GetComponent<Image>().sprite = sprites[indexSprite];
            yield return new WaitForSeconds(time);

            indexSprite++;

        }

        for (int x = 0; x < enemyGenerators.Length; x++)
        {
            enemyGenerators[x].BegingWave(actualWave);

        }
        print(actualWave + "Oleada Actual");
        WaveText.text = "Oleada: " + actualWave.ToString();
        actualWave++;
        indexSprite = 0;

        print(actualWave + "Oleada Siguiente");
        if (!countAudio.isPlaying)
        {
            gameAudio.Play();
        }
        //Destroy (gameObject);
        GetComponent<Image>().enabled = false;
    }



}
