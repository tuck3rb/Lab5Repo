using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour
{
    public AudioClip zero;
    public AudioClip one;
    public AudioClip two;
    public AudioClip three;
    public AudioClip four;
    public AudioClip five;
    public AudioClip six;
    public AudioClip seven;
    public AudioClip eight;
    public AudioClip nine;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.0))
        {
            AudioClip.PlayOneShow (zero, 0.7F);
        }
        if (Input.GetKeyDown(KeyCode.1))
        {
            AudioClip.PlayOneShow (one, 0.7F);
        }
        if (Input.GetKeyDown(KeyCode.2))
        {
            AudioClip.PlayOneShow (two, 0.7F);
        }  
        if (Input.GetKeyDown(KeyCode.3))
        {
            AudioClip.PlayOneShow (three, 0.7F);
        } 
        if (Input.GetKeyDown(KeyCode.4))
        {
            AudioClip.PlayOneShow (four, 0.7F);
        }
        if (Input.GetKeyDown(KeyCode.5))
        {
            AudioClip.PlayOneShow (five, 0.7F);
        }
        if (Input.GetKeyDown(KeyCode.6))
        {
            AudioClip.PlayOneShow (six, 0.7F);
        }
        if (Input.GetKeyDown(KeyCode.7))
        {
            AudioClip.PlayOneShow (seven, 0.7F);
        }
        if (Input.GetKeyDown(KeyCode.8))
        {
            AudioClip.PlayOneShow (eight, 0.7F);
        }
        if (Input.GetKeyDown(KeyCode.9))
        {
            AudioClip.PlayOneShow (nine, 0.7F);
        }                     
    }
    // https://support.unity.com/hc/en-us/articles/
    // 206116386-How-do-I-play-multiple-Audio-Sources
    //-from-one-GameObject-
}
