using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicScript : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
       audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            if(audioSource.isPlaying)
            {
                audioSource.Pause();
            }
            else
            {
                audioSource.Play();
            }
        }
    }

}
