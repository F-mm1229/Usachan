using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsagiCreator : MonoBehaviour
{
    public GameObject usagi;

    float timer = 0;
    int interval = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= interval)
        {
            transform.position = new Vector3(Random.Range(-2.0f, 2.0f), Random.Range(-1.4f, 1.4f), 0);
            Instantiate(usagi, transform.position, transform.rotation);

            timer = 0;
        }
    }
}
