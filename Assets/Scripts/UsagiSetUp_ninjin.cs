using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UsagiSetUp_ninjin : MonoBehaviour
{
    public GameObject scoreCount;
    public Collider2D usagi;

    // 変更したい画像（変更前）
    public GameObject TargetSprite;

    // 変更したい画像（変更先）
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
        // もらったご飯によってうさぎの反応を表す画像に変更する
        if (other.gameObject.CompareTag("ninjin"))
        {
            Debug.Log("にんじんだー！");
            scoreCount.GetComponent<ScoreCount>().ninjinScore();     // スコア加点
            var spriteRenderer = TargetSprite.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = GoodSprite;
            usagi = GetComponent<Collider2D>();
            usagi.isTrigger = false;
        }
        else if (other.gameObject.CompareTag("water") || other.gameObject.CompareTag("timothy")
            || other.gameObject.CompareTag("apple") || other.gameObject.CompareTag("ichigo") || other.gameObject.CompareTag("gohan"))
        {
            Debug.Log("これじゃない");
            scoreCount.GetComponent<ScoreCount>().minusScore();     // スコア減点
            var spriteRenderer = TargetSprite.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = BadSprite;
            usagi = GetComponent<Collider2D>();
            usagi.isTrigger = false;
        }
    }
}
