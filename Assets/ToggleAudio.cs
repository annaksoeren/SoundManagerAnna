using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleAudio : MonoBehaviour
{
    [SerializeField] private bool toggleMusic, toggleSpawn, toggleEffects;

    public void Toggle()
    {
        if (toggleMusic) SoundManager.Instance.ToggleMusic();
        if (toggleSpawn) SoundManager.Instance.ToggleSpawn();
        if (toggleEffects) SoundManager.Instance.ToggleEffects();
    }
}
