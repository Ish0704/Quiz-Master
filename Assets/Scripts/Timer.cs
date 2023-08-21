using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowAnswer = 10f;
    public bool isAnswering = false;
    float timervalue;
    public float fillFraction;
    public bool loadNextQuestion;

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
        timervalue = 0;
    }
    void UpdateTimer()
    {
        timervalue-=Time.deltaTime;
        if (isAnswering)
        {
            if (timervalue > 0)
            {
                fillFraction = timervalue / timeToCompleteQuestion;
            }
            else
            {
                isAnswering = false;
                timervalue = timeToShowAnswer;
            }
        }
        else
        {
            if (timervalue > 0)
            {
                fillFraction = timervalue / timeToShowAnswer;
            }
            else
            {
                isAnswering = true;
                timervalue = timeToCompleteQuestion;
                loadNextQuestion = true;
            }
        }
        Debug.Log(isAnswering + " : " + timervalue + "   " + fillFraction);
    }
}
