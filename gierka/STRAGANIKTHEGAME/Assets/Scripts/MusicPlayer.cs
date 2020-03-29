using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip[] clips;
    private AudioSource audioSource;
    public bool inTrigger;
    public bool music=false; 

    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.loop = false;
    }

    private AudioClip GetRandomClip()
    {
        return clips[Random.Range(0, clips.Length)];
    }

    void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }

    void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }


    void Update()
    {
        if (inTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E)) 
            {
                if (!audioSource.isPlaying)
                {
                    audioSource.clip = GetRandomClip();
                    audioSource.Play();
                    music = true;                   
                }
                else
                {
                    audioSource.Stop();
                    music = false;
                }
            }
            
        }            
    }
    void OnGUI()
    {
        if (inTrigger)
        {
            if (music == false)
            {
                GUI.Box(new Rect(700, 450, 200, 25), "Press E to play music");
            }
        }
        if (inTrigger)
        {
            if (music == true)
            {
                GUI.Box(new Rect(700, 450, 200, 25), "Press E to stop playing music");
            }
        }
    }
}
