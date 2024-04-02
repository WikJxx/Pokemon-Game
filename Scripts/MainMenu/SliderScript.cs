using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public SliderScript sliderInstance;
    private AudioSource audiosrc;
    private float musicVolume = 1f;


    void Start()
    {
        audiosrc = GetComponent<AudioSource>();
    }

    void Update()
    {
        audiosrc.volume = musicVolume;
    }
  
    public void OnValueChange(float vol)
    {
        musicVolume = vol;  
    }
}
