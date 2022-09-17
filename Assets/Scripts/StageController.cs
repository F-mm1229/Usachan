using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour
{
    public GameObject UsagiArea;
    public GameObject FoodArea;

    // Start is called before the first frame update
    void Start()
    {
        FoodArea.SetActive(true);
        UsagiArea.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeToFood()
    {
        FoodArea.SetActive(false);
        UsagiArea.SetActive(true);
        Debug.Log("FoodArea");
    }

    public void ChangeToUsagi()
    {
        FoodArea.SetActive(true);
        UsagiArea.SetActive(false);
    }
}
