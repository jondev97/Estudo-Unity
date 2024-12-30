using UnityEngine;

    // Update is called once per frame
public class EnemyBehavior : MonoBehaviour, IEnemyScore
{
    private readonly int EnemyPoints = 10;
    public float speed = 2f;
    private Transform player;
    private UIManager uiManager;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        uiManager = FindFirstObjectByType<UIManager>();
    }

    void Update()
    {
        if(player != null){
            Vector2 direction = (player.position - transform.position).normalized;

            transform.Translate(Time.deltaTime * speed * direction  );
        }
        
    }

    public void EnemyScore()
    {
        uiManager.UpdateScore(EnemyPoints);
    }
    
}
