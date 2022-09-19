using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsagiCreator : MonoBehaviour
{
    public GameObject usagi_ninjin;
    public GameObject usagi_water;

    float timer_ninjin = 0;
    float timer_water = 0;
    int interval_ninjin = 6;
    int interval_water = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer_ninjin += Time.deltaTime;
        timer_water += Time.deltaTime;

        if (timer_ninjin >= interval_ninjin)
        {
            transform.position = new Vector3(Random.Range(-2.0f, 2.0f), Random.Range(-1.4f, 1.4f), 0);
            Instantiate(usagi_ninjin, transform.position, transform.rotation);

            timer_ninjin = 0;
        }

        if (timer_water >= interval_water)
        {
            transform.position = new Vector3(Random.Range(-2.0f, 2.0f), Random.Range(-1.4f, 1.4f), 0);
            Instantiate(usagi_water, transform.position, transform.rotation);

            timer_water = 0;
        }
    }
}
