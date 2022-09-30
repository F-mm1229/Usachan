using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toMain()
    {
        SceneManager.LoadScene("Main");
        ScoreCount.scoreSum = 0;
        ScoreScene.revel = PlayerPrefs.GetInt("REVEL", ScoreScene.revel);
    }

    public void toScoreScene()
    {
        SceneManager.LoadScene("ScoreScene");
    }

    public void toTitle()
    {
        SceneManager.LoadScene("Title");
        ScoreCount.scoreSum = 0;
    }
}
