using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    [SerializeField] private AudioSource musicSource, spawnSource, effectsSource;

    void Awake() 
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySound(AudioClip clip)
    {
        effectsSource.PlayOneShot(clip);
    }

        public void ChangeMasterVolume(float value)
    { 
        AudioListener.volume = value;
    }

    public void ToggleMusic()
    {
        musicSource.mute = !musicSource.mute;
    }

    public void ToggleSpawn()
    {
        spawnSource.mute = !spawnSource.mute;
    }

    public void ToggleEffects()
    {
        effectsSource.mute = !effectsSource.mute;
    }
}
