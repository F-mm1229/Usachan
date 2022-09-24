using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{
    float delayUntilDestroyed = 10;         // 何秒後に消すのか

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, delayUntilDestroyed);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        // Foodがusagiに当たった時に消す
        if (collision.gameObject.CompareTag("usagi"))
        {
            Destroy(this.gameObject);
        }
    }
}
