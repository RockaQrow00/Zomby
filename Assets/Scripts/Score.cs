using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int scoreOnKill;
    public int currentScore;

    [SerializeField] private Text scoreText;

    public void Start()
    {
        InitVariables();
    }

    private void InitVariables()
    {
        currentScore = 0;
        scoreOnKill = 1;
    }


    public void AddOneScore()
    {
        currentScore += scoreOnKill;
        scoreText.text = currentScore.ToString();
    }
}
