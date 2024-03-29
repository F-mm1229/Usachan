using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public static int scoreSum = 0;
    public static int totalScore = 0;

    public Text TextScore;
    public Text TextScoreEffect;

    float a_color;

    // Start is called before the first frame update
    void Start()
    {
        totalScore = PlayerPrefs.GetInt("SCORE", 0);
        a_color = 0;

        
    }

    // Update is called once per frame
    void Update()
    {
        TextScore.text = "Score : " + scoreSum.ToString();
        TextScoreEffect.color = new Color(0, 0, 0, a_color);
    }

    public void ninjinScore()
    {
        scoreSum += 20;
        scoreEffect(30);
    }

    public void waterScore()
    {
        scoreSum += 30;
        scoreEffect(20);
    }

    public void timothyScore()
    {
        scoreSum += 40;
        scoreEffect(50);
    }

    public void appleScore()
    {
        scoreSum += 40;
        scoreEffect(50);
    }

    public void ichigoScore()
    {
        scoreSum += 50;
        scoreEffect(50);
    }

    public void gohanScore()
    {
        scoreSum += 50;
        scoreEffect(50);
    }

    public void minusScore()
    {
        scoreSum -= 10;
        scoreEffect(-10);
    }

    public void scoreEffect(int i)
    {
        a_color = 1;
        TextScoreEffect.text = "+" + i.ToString();
        if (i <= 0)
        {
            TextScoreEffect.text = i.ToString();
        }

        Invoke("a_reset", 0.8f);
    }

    public void a_reset()
    {
        a_color = 0;
    }

    public void scoreSave()
    {
        totalScore += scoreSum;
        PlayerPrefs.SetInt("SCORE", totalScore);
        PlayerPrefs.Save();
    }

    public void totalScoreReset()
    {
        totalScore = 0;
        PlayerPrefs.SetInt("SCORE", 0);
        PlayerPrefs.Save();
        ScoreScene.revel = 1;
        Debug.Log("reset");
    }

    public void scoreReset()
    {
        scoreSum = 0;
    }
}
