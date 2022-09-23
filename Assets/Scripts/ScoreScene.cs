using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScene : MonoBehaviour
{
    public Text score;
    public Text TotalScore;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score : " + ScoreCount.scoreSum.ToString();
        TotalScore.text = "Total Score : " + ScoreCount.totalScore.ToString();
        //Debug.Log(ScoreCount.scoreSum);

    }
}
