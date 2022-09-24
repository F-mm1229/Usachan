using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCreator : MonoBehaviour
{
    public GameObject ninjin;       // にんじん
    public GameObject water;        // お水

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // にんじんを指定した位置に複製する関数
    public void generateNinjin()
    {
        transform.position = new Vector3(Random.Range(-8.0f, 8.0f), -4.2f, 0);
        Instantiate(ninjin, transform.position, transform.rotation);
    }

    // お水を指定した位置に複製する関数
    public void generateWater()
    {
        transform.position = new Vector3(Random.Range(-8.0f, 8.0f), -4.2f, 0);
        Instantiate(water,  transform.position, transform.rotation);
    }
}
