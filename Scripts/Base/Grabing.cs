using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabing : MonoBehaviour
{
    public AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }
    public void Play()
    {
        source.Play();
    }
}
