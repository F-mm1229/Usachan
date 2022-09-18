using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprete : MonoBehaviour
{
    public SpriteRenderer ninjin_SR;
    public SpriteRenderer heart_SR;

    // Start is called before the first frame update
    void Start()
    {
        ninjin_SR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeSpreteToHeart()
    {
        ninjin_SR.sprite = heart_SR.sprite;
    }
}
