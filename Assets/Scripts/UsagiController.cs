using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsagiController : MonoBehaviour
{
    float delayUntilDestroyed =  10;         // 何秒後に消すのか

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, delayUntilDestroyed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
