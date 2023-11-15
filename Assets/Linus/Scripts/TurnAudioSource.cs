using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnAudioSource : MonoBehaviour
{
        private AudioSource audioSource;

        public void Change()
        {
                audioSource = GetComponent<AudioSource>();

                audioSource.enabled = !audioSource.enabled;
        }
        
}
