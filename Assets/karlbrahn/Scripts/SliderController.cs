using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SliderController : MonoBehaviour
{
    public AudioMixer mixer;

    public void SetLevel (float sliderValue)
    {
        if(gameObject.tag == "sliderMusic") {
            mixer.SetFloat("Music", Mathf.Log10(sliderValue) * 20);
        }

        if(gameObject.tag == "sliderSound") {
            mixer.SetFloat("SFX", Mathf.Log10(sliderValue) * 20);
        }
    }
}
