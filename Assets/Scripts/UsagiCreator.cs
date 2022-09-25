using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsagiCreator : MonoBehaviour
{
    public GameObject usagi_ninjin;     // にんじんが欲しいうさぎ
    public GameObject usagi_water;      // お水が欲しいうさぎ
    public GameObject usagi_timothy;    // チモシーが欲しいうさぎ
    public GameObject usagi_apple;      // りんごが欲しいうさぎ
    public GameObject usagi_ichigo;     // いちごが欲しいうさぎ
    public GameObject usagi_gohan;      // ごはんが欲しいうさぎ


    float timer_ninjin = 0;             // にんじんが欲しいうさぎのタイマー
    float timer_water = 0;              // お水が欲しいうさぎのタイマー
    float timer_timothy = 0;            // チモシーが欲しいうさぎのタイマー
    float timer_apple = 0;              // りんごが欲しいうさぎのタイマー
    float timer_ichigo = 0;             // いちごが欲しいうさぎのタイマー
    float timer_gohan = 0;              // ごはんが欲しいうさぎのタイマー

    int interval_ninjin = 6;            // にんじんが欲しいうさぎが出現する間隔
    int interval_water = 10;            // お水が欲しいうさぎが出現する間隔
    int interval_timothy = 8;           // チモシーが欲しいうさぎが出現する間隔
    int interval_apple = 11;            // りんごが欲しいうさぎが出現する間隔
    int interval_ichigo = 12;           // いちごが欲しいうさぎが出現する間隔
    int interval_gohan = 15;            // ごはんが欲しいうさぎが出現する間隔

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // タイマー稼働
        timer_ninjin += Time.deltaTime;
        timer_water += Time.deltaTime;
        timer_timothy += Time.deltaTime;
        timer_apple += Time.deltaTime;
        timer_ichigo += Time.deltaTime;
        timer_gohan += Time.deltaTime;

        // にんじんが欲しいうさぎをランダムな場所に出現させる
        if (timer_ninjin >= interval_ninjin)
        {
            transform.position = new Vector3(Random.Range(-8.0f, 1.5f), Random.Range(-2.5f, 1.5f), 0);
            Instantiate(usagi_ninjin, transform.position, transform.rotation);

            timer_ninjin = 0;
        }

        // お水が欲しいうさぎをランダムな場所に出現させる
        if (timer_water >= interval_water)
        {
            transform.position = new Vector3(Random.Range(-8.0f, 1.5f), Random.Range(-2.5f, 1.5f), 0);
            Instantiate(usagi_water, transform.position, transform.rotation);

            timer_water = 0;
        }

        // チモシーが欲しいうさぎをランダムな場所に出現させる
        if (ScoreScene.revel >= 2)
        {
            if (timer_timothy >= interval_timothy)
            {
                transform.position = new Vector3(Random.Range(-8.0f, 1.5f), Random.Range(-2.5f, 1.5f), 0);
                Instantiate(usagi_timothy, transform.position, transform.rotation);

                timer_timothy = 0;
            }

        }

        // りんごが欲しいうさぎをランダムな場所に出現させる
        if (ScoreScene.revel >= 3)
        {
            if (timer_apple >= interval_apple)
            {
                transform.position = new Vector3(Random.Range(-8.0f, 1.5f), Random.Range(-2.5f, 1.5f), 0);
                Instantiate(usagi_apple, transform.position, transform.rotation);

                timer_apple = 0;
            }
        }

        // いちごが欲しいうさぎをランダムな場所に出現させる
        if (ScoreScene.revel >= 4)
        {
            if (timer_ichigo >= interval_ichigo)
            {
                transform.position = new Vector3(Random.Range(-8.0f, 1.5f), Random.Range(-2.5f, 1.5f), 0);
                Instantiate(usagi_ichigo, transform.position, transform.rotation);

                timer_ichigo = 0;
            }
        }

        // ごはんが欲しいうさぎをランダムな場所に出現させる
        if (ScoreScene.revel >= 5)
        {
            if (timer_gohan >= interval_gohan)
            {
                transform.position = new Vector3(Random.Range(-8.0f, 1.5f), Random.Range(-2.5f, 1.5f), 0);
                Instantiate(usagi_gohan, transform.position, transform.rotation);

                timer_gohan = 0;
            }
        }
    }

}
