using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UsagiSetUp : MonoBehaviour
{
    public static int requests = 1;
    //public Text TextRequest;

    public GameObject scoreCount;
    //public GameObject changeSprete;
    //public GameObject changeRequest;

    // Start is called before the first frame update
    void Start()
    {
        //requests = Random.Range(1, 4);
        //TextRequest = gameObject.Find("")
        scoreCount = GameObject.Find("ScoreCount");
        //changeSprete = GameObject.Find("ChangeSprete");
        //changeRequest = GameObject.Find("ChangeRequest");

        //if (requests == 2)
        //{
        //    changeRequest.GetComponent<ChangeRequest>().waterRequest();

        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ninjin"))
        {
            Debug.Log("にんじんだ！");

            if (requests == 1)
            {
                scoreCount.GetComponent<ScoreCount>().ninjinScore();
                //changeSprete.GetComponent<ChangeSprete>().changeSpreteToHeart();

            }
        }

        if (other.gameObject.CompareTag("water"))
        {
            Debug.Log("お水だ！");

            if (requests == 2)
            {
                //TextRequest.text = "ありがとう！";
                scoreCount.GetComponent<ScoreCount>().waterScore();
            }
        }

        if (other.gameObject.CompareTag("timothy"))
        {
            Debug.Log("チモシーだ！");

            if (requests == 3)
            {
                scoreCount.GetComponent<ScoreCount>().timothyScore();
                //TextRequest.text = "ありがとう！";
            }
        }
    }
}
