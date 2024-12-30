using System;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyPrefab;
    public float initialSpawnRate = 2f;
    public float spawnRate = 0.1f;

    public float spawnDistance = 10f;

    private Transform player;
    private float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        spawnRate = initialSpawnRate;

        //InvokeRepeating("SpawnEnemy", spawnRate, spawnRate);
    }
    
    
    // Update is called once per frame
    void Update(){
        timer += Time.deltaTime;

        if(timer >= spawnRate){
            SpawnEnemy();
            timer = 0;
            spawnRate = Mathf.Max(0.5f, spawnRate - 0.05f);
        }
    }
    
    void SpawnEnemy()
    {
        if(player != null){
            Vector2 spawnPosition = player.position + (Vector3)UnityEngine.Random.insideUnitCircle.normalized * spawnDistance;
            GameObject enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

            // Aumenta a velocidade dos inimigos progressivamente
            enemy.GetComponent<EnemyBehavior>().speed += 0.1f;
        }
    }
}
