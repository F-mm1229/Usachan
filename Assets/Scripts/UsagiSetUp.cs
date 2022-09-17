using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UsagiSetUp : MonoBehaviour
{
    public int requests = 1;
    public Text TextRequest;

    // Start is called before the first frame update
    void Start()
    {
        //requests = Random.Range(1, 4);

        if (requests == 1)
        {
            TextRequest.text = "にんじんが欲しいな〜";
        }
        else if (requests == 2)
        {
            TextRequest.text = "お水が欲しいな〜";
        }
        else if (requests == 3)
        {
            TextRequest.text = "チモシーが欲しいな〜";
        }
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
                TextRequest.text = "ありがとう！";
            }
        }

        if (other.gameObject.CompareTag("water"))
        {
            Debug.Log("お水だ！");

            if (requests == 2)
            {
                TextRequest.text = "ありがとう！";
            }
        }

        if (other.gameObject.CompareTag("timothy"))
        {
            Debug.Log("チモシーだ！");

            if (requests == 3)
            {
                TextRequest.text = "ありがとう！";
            }
        }
    }
}
