using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

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




    public void playSound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

    public void ChangeMasterVolume(float val)
    {
        AudioListener.volume = val;
    }
}
