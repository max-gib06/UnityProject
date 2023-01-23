using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public Sound[] sounds;
    // Start is called before the first frame update
    void Awake()
    {
        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.vol;
            s.source.pitch = s.pitch;
           
        }
        
    }

    // Update is called once per frame
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, Sound => Sound.name == name);
        if(s == null)
        {
            Debug.LogWarning("Sound: " + name + " does not exist!");
            return;
        }
        s.source.Play();
    }
}
