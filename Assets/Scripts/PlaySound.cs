using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    private AudioSource sounds;
    private void Start()
    {
        sounds= GetComponent<AudioSource>();
    }
    public void Play()
    {
        sounds.Play();
    }
}
