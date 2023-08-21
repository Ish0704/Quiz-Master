using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Quiz quiz;
    GameOver gameOver;
    void Awake()
    {
        quiz = FindObjectOfType<Quiz>();
        gameOver = FindObjectOfType<GameOver>();
    }
    // Start is called before the first frame update
    void Start()
    {
         
        quiz.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      if(quiz.isComplete==true)
        {
            quiz.gameObject.SetActive(false);
            gameOver.gameObject.SetActive(true);
            gameOver.FinalScore();
        }
    }
    public void ReplayGame()
    {
        SceneManager.LoadScene("Quizscene");
    }
}
