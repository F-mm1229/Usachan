using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCreator : MonoBehaviour
{
    public GameObject ninjin;       // にんじん
    public GameObject water;        // お水
    public GameObject timothy;      // チモシー
    public GameObject apple;        // りんご
    public GameObject ichigo;       // いちご
    public GameObject gohan;        // ごはん

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

    // チモシーを指定した位置に複製する関数
    public void generateTimothy()
    {
        transform.position = new Vector3(Random.Range(-8.0f, 8.0f), -4.2f, 0);
        Instantiate(timothy, transform.position, transform.rotation);
    }

    // りんごを指定した位置に複製する関数
    public void generateApple()
    {
        transform.position = new Vector3(Random.Range(-8.0f, 8.0f), -4.2f, 0);
        Instantiate(apple, transform.position, transform.rotation);
    }

    // いちごを指定した位置に複製する関数
    public void generateIchigo()
    {
        transform.position = new Vector3(Random.Range(-8.0f, 8.0f), -4.2f, 0);
        Instantiate(ichigo, transform.position, transform.rotation);
    }

    // ごはんを指定した位置に複製する関数
    public void generateGohan()
    {
        transform.position = new Vector3(Random.Range(-8.0f, 8.0f), -4.2f, 0);
        Instantiate(gohan, transform.position, transform.rotation);
    }
}
