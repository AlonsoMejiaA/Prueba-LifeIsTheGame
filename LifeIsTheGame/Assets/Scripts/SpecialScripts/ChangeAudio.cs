using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAudio : MonoBehaviour
{
    [SerializeField] AudioSource music;

    public void ChangAudio(AudioClip clip)
    {
        music.clip = clip;
        music.Play();
    }
}
