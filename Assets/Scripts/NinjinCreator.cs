using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjinCreator : MonoBehaviour
{
    public GameObject ninjin;

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
        Instantiate(ninjin, new Vector2(7.2f, 0.5f), transform.rotation);
    }
}
