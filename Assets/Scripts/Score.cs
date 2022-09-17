using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int scoreSum = 0;
    public Text TextScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextScore.text = String.Format("Score :" + scoreSum);

    }


}
