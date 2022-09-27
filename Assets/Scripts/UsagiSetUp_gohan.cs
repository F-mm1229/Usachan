using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsagiSetUp_gohan : MonoBehaviour
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
        if (other.gameObject.CompareTag("gohan"))
        {
            Debug.Log("ごはんだー！");
            scoreCount.GetComponent<ScoreCount>().gohanScore();     // スコア加点
            var spriteRenderer = TargetSprite.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = GoodSprite;
            usagi = GetComponent<Collider2D>();
            usagi.isTrigger = false;
        }
        else if (other.gameObject.CompareTag("ninjin") || other.gameObject.CompareTag("timothy")
            || other.gameObject.CompareTag("water") || other.gameObject.CompareTag("ichigo") || other.gameObject.CompareTag("apple"))
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
