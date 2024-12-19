using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text scoreText;
    private int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void AddScore(int points)
    {
        score += points; // Adiciona os pontos
        scoreText.text = "Score: " + score; // Atualiza o texto da UI
    }
}
