using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UsagiSetUp_ninjin : MonoBehaviour
{
    public static int requests = 1;

    public GameObject scoreCount;
    public GameObject TargetSprite;
    public Sprite GoodSprite;
    public Sprite BadSprite;

    // Start is called before the first frame update
    void Start()
    {
        scoreCount = GameObject.Find("ScoreCount");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("ninjin"))
        {
            Debug.Log("にんじんだー！");
            scoreCount.GetComponent<ScoreCount>().ninjinScore();
            var spriteRenderer = TargetSprite.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = GoodSprite;
        }
        else if (other.gameObject.CompareTag("water"))
        {
            Debug.Log("これじゃない");
            var spriteRenderer = TargetSprite.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = BadSprite;
        }
    }
}
