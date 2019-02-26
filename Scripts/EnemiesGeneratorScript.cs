using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesGeneratorScript : MonoBehaviour
{

    public int enemigosCount = 20;
    public GameObject[] enemyPrefab;
    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;
    private GameObject newEnemy;
    bool generating = false;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnEnemy()
    {
        int random = Random.Range(0, enemyPrefab.Length);
        newEnemy = Instantiate(enemyPrefab[random], transform.position, transform.rotation);
        newEnemy.transform.SetParent(transform);


    }

    public void BegingWave(int numberOfWave)
    {
        generating = true;
        StartCoroutine(Respawn(numberOfWave));
    }

    //TODO
    public void StopWave()
    {
        generating = false;
    }

    IEnumerator Respawn(int numberOfWave)
    {
        while (generating)
        {
            SpawnEnemy();
            countdown = timeBetweenWaves;
            print("GENERANDO ENEMIGOS ");
            yield return new WaitForSeconds(countdown); //TODO: Calcular tiempo entre oleadas
        }
    }

}