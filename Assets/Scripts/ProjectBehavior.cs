using UnityEngine;

public class ProjectBehavior : MonoBehaviour
{
    public float speed = 10f;
    private Vector2 direction;

    public void SetDirection(Vector2 newDirection)
    {
        direction = newDirection.normalized;
    }

    void Update()
    {
        // Move o projétil na direção configurada
        if (direction != Vector2.zero)
        {
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
     void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Enemy")){
            Destroy(other.gameObject);
            Destroy(gameObject);
        GameObject.Find("GameManager").GetComponent<ScoreManager>().AddScore(10);
        }

    }
}
