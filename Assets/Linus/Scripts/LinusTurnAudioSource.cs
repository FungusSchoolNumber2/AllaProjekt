using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinusTurnAudioSource : MonoBehaviour
{
        private AudioSource audioSource;

        public void Change()
        {
                audioSource = GetComponent<AudioSource>();

                audioSource.enabled = !audioSource.enabled;
        }
        
}
