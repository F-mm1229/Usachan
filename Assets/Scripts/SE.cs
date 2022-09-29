using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SE : MonoBehaviour
{
    public AudioClip timeUp;
    public AudioClip buzzer;
    public AudioClip kirakira;

    AudioSource audioSource;

    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 29.2)
        {
            audioSource.PlayOneShot(timeUp);
            timer = 0;
        }
    }

    public void Buzzer()
    {
        audioSource.PlayOneShot(buzzer);
    }

    public void Kirakira()
    {
        audioSource.PlayOneShot(kirakira);
    }
}
