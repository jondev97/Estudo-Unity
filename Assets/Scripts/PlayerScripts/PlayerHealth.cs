using UnityEngine;

public class Player : MonoBehaviour, IDamageable
{
    public int health = 100;
    public UIManager uiManager;

    private void Start() {
        uiManager = FindFirstObjectByType<UIManager>();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        
        if(uiManager){
            uiManager.UpdateHeath(health);
        }

        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("O jogador morreu!");
        Time.timeScale = 0;
    }
}