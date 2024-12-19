using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyPrefab;
    
    public float spawnRate = 0.1f;

    public float spawnDistance = 10f;

    private Transform player;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        
        InvokeRepeating("SpawnEnemy", spawnRate, spawnRate);
    }

    // Update is called once per frame
    void SpawnEnemy()
    {
        if(player != null){
            Vector2 spawnPosition = player.position + (Vector3)Random.insideUnitCircle.normalized * spawnDistance;
            
            // Instantiate cria uma copia do objeto
            Instantiate(enemyPrefab,spawnPosition, Quaternion.identity );
        }
    }
}
