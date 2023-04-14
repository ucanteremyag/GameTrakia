using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class Klarnet : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;
    private void OnTriggerEnter(Collider other)
    {
        SoundManager.Instance.PlaySound(_clip);
    }
}
