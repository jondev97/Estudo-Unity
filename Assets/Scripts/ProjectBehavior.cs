using UnityEngine;

public class ProjectBehavior : MonoBehaviour
{
    public float speed = 10f;
    private Vector2 direction;

    private int attack = 20;

    public void SetDirection(Vector2 newDirection)
    {
        direction = newDirection.normalized;

    }

    void Update()
    {
        // Move o projétil na direção configurada
        if (direction != Vector2.zero)
        {
            transform.Translate(Time.deltaTime * speed * direction);
        }
    }
    
     void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Enemy")){
            
            // Redução hp inimigo 
            EnemyHealth enemyHealth = other.gameObject.GetComponent<EnemyHealth>();           
            enemyHealth.Health -= attack;
            Destroy(gameObject);

            if(enemyHealth.Health <= 0 ){

            IEnemyScore ScorePoints = other.gameObject.GetComponent<IEnemyScore>();
            ScorePoints?.EnemyScore();
            
            Destroy(other.gameObject);
            }


           

            
        }

    }
}
