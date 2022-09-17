using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropArea : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void OnDrop(PointerEventData eventData)
    //{
    //    Debug.Log(gameObject.name + "に" + eventData.pointerDrag.name + "がドロップされました。");
    //}

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ninjin"))
        {
            Debug.Log("にんじんだ！");
        }
    }
}
