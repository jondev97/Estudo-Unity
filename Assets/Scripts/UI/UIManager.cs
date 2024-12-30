using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI scoreText;

    private int score = 0;

    void Start()
    {
        UpdateScore(0);
        UpdateHeath(100);
    }

    public void UpdateHeath(int health)
    {
        healthText.text = "Saúde: " + health.ToString();
    }

    public void UpdateScore(int amount)
    {
        score += amount;
        scoreText.text = "Pontuação: " + score.ToString();
    }
}