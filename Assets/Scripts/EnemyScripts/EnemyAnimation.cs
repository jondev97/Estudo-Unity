using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private PlayerMovement player;
    private Player dead;
    private Animator anim;
    
    void Start()
    {
        player = GetComponent<PlayerMovement>();
        anim = GetComponent<Animator>();
        dead = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        //sqrMagnitude recebe o valor do vector2 e retorna a media do valor de x,y
        if(player._movement.sqrMagnitude > 0){
            anim.SetInteger("transition",1);
        }
        else
        {
            anim.SetInteger("transition",0);

        }
        //X > 0 está indo para a direita
        if(player._movement.x > 0){
            transform.eulerAngles = new Vector2(0,0);
        }
        //x < 0 está indo para esquerda 
        if(player._movement.x < 0){
            transform.eulerAngles = new Vector2(0,180);
        }
        if (dead.health <= 0)
        {
            anim.SetInteger("transition", 2);
            Debug.Log(dead.health);
        }
    }

    
}
