using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public static float CountDownTime;
    public Text TextCountDown;

    public GameObject scoreCount;

    public SceneController sceneController;

    public Image UIobj;
    public bool roop;
    public float countTime = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        CountDownTime = 30.0f;
        scoreCount = GameObject.Find("ScoreCount");
    }

    // Update is called once per frame
    void Update()
    {
        TextCountDown.text = String.Format("{0:00}", CountDownTime);
        CountDownTime -= Time.deltaTime;

        if (CountDownTime <= 0.0f)
        {
            scoreCount.GetComponent<ScoreCount>().scoreSave();     // スコア保存
            sceneController.toScoreScene();
        }

        if (roop)
        {
            UIobj.fillAmount -= 1.0f / countTime * Time.deltaTime;
        }
    }
}
