using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    [SerializeField] private AudioSource _musicSource, _effectSource;
    private void Awake()
    {



    }

    public void PlaySound(AudioClip clip)
    {
        _effectSource.PlayOneShot(clip);
    }
}
