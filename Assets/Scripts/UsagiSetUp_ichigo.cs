using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsagiSetUp_ichigo : MonoBehaviour
{
    public GameObject scoreCount;

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
        if (other.gameObject.CompareTag("ichigo"))
        {
            Debug.Log("いちごだー！");
            scoreCount.GetComponent<ScoreCount>().ichigoScore();     // スコア加点
            var spriteRenderer = TargetSprite.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = GoodSprite;
        }
        else if (other.gameObject.CompareTag("ninjin") || other.gameObject.CompareTag("timothy")
            || other.gameObject.CompareTag("water") || other.gameObject.CompareTag("apple") || other.gameObject.CompareTag("gohan"))
        {
            Debug.Log("これじゃない");
            scoreCount.GetComponent<ScoreCount>().minusScore();     // スコア減点
            var spriteRenderer = TargetSprite.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = BadSprite;
        }

    }
}
