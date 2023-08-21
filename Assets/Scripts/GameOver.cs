using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI gameOverText;
    Score score;
    void Awake()
    {
        score=FindObjectOfType<Score>();
    }
    public void FinalScore()
    {
        gameOverText.text="CONGRATULATIONS!\nYOU GOT A SCORE OF "+score.CalculateScore()+"%";
    }
}
