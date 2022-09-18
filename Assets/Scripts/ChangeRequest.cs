using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeRequest : MonoBehaviour
{
    public GameObject ninjinImg;
    public GameObject waterImg;

    // Start is called before the first frame update
    void Start()
    {
        if (UsagiSetUp.requests == 1)
        {
            ninjinImg.SetActive(true);
            waterImg.SetActive(false);
        }
        else if (UsagiSetUp.requests == 2)
        {
            ninjinImg.SetActive(false);
            waterImg.SetActive(true);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void ChangeToWater()
    //{
    //    ninjinImg.SetActive(false);
    //    waterImg.SetActive(true);
    //    Debug.Log("water");
    //}
}
