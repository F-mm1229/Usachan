using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequestImgChanger : MonoBehaviour
{
    public Texture[] textures;
    Renderer requestRenderer;

    // Start is called before the first frame update
    void Start()
    {
        requestRenderer = GetComponent<Renderer>();
        requestRenderer.material.mainTexture = textures[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
