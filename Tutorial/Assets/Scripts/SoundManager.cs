using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager music {get; private set;}
    private AudioSource source;
    public GameObject image;
    private void Awake()
    {
        music = this;
        source = GetComponent<AudioSource>();
        DontDestroyOnLoad(gameObject);
    } 

    public void PlaySound(AudioClip sound)
    {
        source.PlayOneShot(sound); 
    }
    private void Update()
    {
        if (!source.isPlaying && (source.time == 0f))
        {
            image.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
