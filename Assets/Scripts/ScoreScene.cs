using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScene : MonoBehaviour
{
    public Text score;
    public Text TotalScore;

    public Text revel;
    public Text penName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score : " + ScoreCount.scoreSum.ToString();
        TotalScore.text = "Total Score : " + ScoreCount.totalScore.ToString();

        if (ScoreCount.totalScore >= 400)
        {
            revel.text = "2";
            penName.text = "ふつうのかいぬし";
        }
        if (ScoreCount.totalScore >= 500)
        {
            revel.text = "3";
            penName.text = "しごとができるかいぬし";
        }
        if (ScoreCount.totalScore >= 700)
        {
            revel.text = "4";
            penName.text = "りっぱなかいぬし";
        }
        if (ScoreCount.totalScore >= 900)
        {
            revel.text = "5";
            penName.text = "スーパーかいぬし";
        }
    }
}
