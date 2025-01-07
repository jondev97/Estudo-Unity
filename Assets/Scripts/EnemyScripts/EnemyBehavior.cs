using UnityEngine;

    // Update is called once per frame
public class EnemyBehavior : MonoBehaviour, IEnemyScore
{
    private readonly int EnemyPoints = 10;
    public float speed = 2f;
    private Transform player;
    private UIManager uiManager;
    private PlayerHealth dead;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        uiManager = FindFirstObjectByType<UIManager>();
        dead = player.GetComponent<PlayerHealth>();
    }

    void Update()
    {

        if(player != null){
            Vector2 direction = (player.position - transform.position).normalized;

            transform.Translate(Time.deltaTime * speed * direction  );

        }



        if (dead != null && dead.isDead)
        {
            speed = 0f;
            return; // Impede outras ações do inimigo, se necessário
    
        }

            //Redução hp inimigo

    

        float posX = player.position.x - transform.position.x;

        if(posX > 0){
            transform.localScale = new Vector3(1,1,1);
        }else{
            transform.localScale = new Vector3(-1,1,1);
        }

    }
    public void EnemyScore()
    {
        uiManager.UpdateScore(EnemyPoints);
    }
    
}
