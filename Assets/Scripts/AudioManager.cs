using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    private float audioBreak = 0;

    [SerializeField] private AudioSource audioSource;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        if (audioBreak > 0)
        { 
            audioBreak -= Time.deltaTime;
        }
    }




    public void playSound(AudioClip clip)
    {

            audioSource.PlayOneShot(clip);
        
    }

    public void playLoudSound(AudioClip clip)
    {
        if (audioBreak <= 0)
        {
            audioSource.PlayOneShot(clip);
            audioBreak = 3;
        }

    }

    public void ChangeMasterVolume(float val)
    {
        AudioListener.volume = val;
    }
}
