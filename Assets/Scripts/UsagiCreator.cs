using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsagiCreator : MonoBehaviour
{
    public GameObject usagi_ninjin;     // にんじんが欲しいうさぎ
    public GameObject usagi_water;      // お水が欲しいうさぎ

    float timer_ninjin = 0;             // にんじんが欲しいうさぎのタイマー
    float timer_water = 0;              // お水が欲しいうさぎのタイマー
    int interval_ninjin = 6;            // にんじんが欲しいうさぎが出現する間隔
    int interval_water = 10;            // お水が欲しいうさぎが出現する間隔

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
    }
}
