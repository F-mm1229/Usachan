using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{
    public UsagiSetUp usagiSetUp;
    //public int tagId;

    //public GameObject ninjin;
    //public GameObject water;

    // Start is called before the first frame update
    void Start()
    {
        //tagId = int.Parse(this.gameObject.tag);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("usagi") && usagiSetUp.requests == 1)
        {
            Destroy(this.gameObject);
        }

        
    }
}
