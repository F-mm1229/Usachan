using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public static float CountDownTime;
    public Text TextCountDown;

    public SceneController sceneController;

    // Start is called before the first frame update
    void Start()
    {
        CountDownTime = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        TextCountDown.text = String.Format("残り時間 : {0:00.00}", CountDownTime);
        CountDownTime -= Time.deltaTime;

        if (CountDownTime <= 0.0f)
        {
            sceneController.toScoreScene();
        }
    }
}
