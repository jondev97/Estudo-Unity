using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour, IDamageable
{
    public int health = 100;
    public UIManager uiManager;
    private PlayerMovement playerMovement;
    public GameObject gameOverPanel;
    public bool isDead = false;
    private void Start() {
        uiManager = FindFirstObjectByType<UIManager>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    public int TakeDamage(int damage)
    {
        if(isDead) return health;
        health -= damage;
        
        if(uiManager){
            uiManager.UpdateHeath(health);
        }

        if (health <= 0)
        {
            Die();
            GameOver();
        }
            return health;
    }

    private void Die()
    {
        isDead = true;
        Debug.Log("O jogador morreu!");
        Time.timeScale = 0;
    }
     public bool IsDead() => isDead;
    void GameOver()
    {
        if(playerMovement != null){
            playerMovement.enabled = false;
        }
        gameOverPanel.SetActive(true);
        Time.timeScale = 1f;
    }

    public void RestartGame(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}