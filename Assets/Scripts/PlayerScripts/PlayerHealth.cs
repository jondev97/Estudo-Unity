using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour, IDamageable
{
    public int health = 100;
    public UIManager uiManager;

    public GameObject gameOverPanel;
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
            GameOver();
        }
    }

    private void Die()
    {
        Debug.Log("O jogador morreu!");
        Time.timeScale = 0;
    }

    void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}