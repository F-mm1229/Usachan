using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCreator : MonoBehaviour
{
    public GameObject ninjin;
    public GameObject water;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void generateNinjin()
    {
        Instantiate(ninjin, new Vector2(7.5f, 0.4f), transform.rotation);
    }

    public void generateWater()
    {
        Instantiate(water, new Vector2(4.7f, 0.3f), transform.rotation);
    }
}
