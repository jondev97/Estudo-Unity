using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
        float speed = 2f;

        private Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null){
            Vector2 direction = (player.position - transform.position).normalized;

            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
}
