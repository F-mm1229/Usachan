using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScene : MonoBehaviour
{
    public Text score;
    public Text TotalScore;

    public Text revelText;
    public Text penNameText;

    public static int revel;

    // Start is called before the first frame update
    void Start()
    {
        //revel = 1;
        TotalScore.text = "Total Score : " + ScoreCount.totalScore.ToString();
        revel = PlayerPrefs.GetInt("REVEL", revel);
        Debug.Log(revel);
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score : " + ScoreCount.scoreSum.ToString();
        TotalScore.text = "Total Score : " + ScoreCount.totalScore.ToString();

        if (ScoreCount.totalScore >= 0)
        {
            revel = 1;
            revelText.text = "1";
            penNameText.text = "みならいのかいぬし";
            revelSave();
        }
        if (ScoreCount.totalScore >= 200)
        {
            revel = 2;
            revelText.text = "2";
            penNameText.text = "ふつうのかいぬし";
            revelSave();
        }
        if (ScoreCount.totalScore >= 400)
        {
            revel = 3;
            revelText.text = "3";
            penNameText.text = "しごとができるかいぬし";
            revelSave();
        }
        if (ScoreCount.totalScore >= 700)
        {
            revel = 4;
            revelText.text = "4";
            penNameText.text = "りっぱなかいぬし";
            revelSave();
        }
        if (ScoreCount.totalScore >= 900)
        {
            revel = 5;
            revelText.text = "5";
            penNameText.text = "スーパーかいぬし";
            revelSave();
        }
    }

    public void revelSave()
    {
        PlayerPrefs.SetInt("REVEL", revel);
        PlayerPrefs.Save();
    }
}
