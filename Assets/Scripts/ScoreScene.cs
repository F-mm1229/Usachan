using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScene : MonoBehaviour
{
    public Text scoreSceneText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreSceneText.text = "Score : " + ScoreCount.scoreSum.ToString();
        //Debug.Log(ScoreCount.scoreSum);

    }
}
