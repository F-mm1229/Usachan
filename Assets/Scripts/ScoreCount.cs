using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public static int scoreSum = 0;
    public Text TextScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextScore.text = "Score :" + scoreSum.ToString();

    }

    public void ninjinScore()
    {
        scoreSum += 30;
    }

    public void waterScore()
    {
        scoreSum += 20;
    }

    public void timothyScore()
    {
        scoreSum += 50;
    }
}
