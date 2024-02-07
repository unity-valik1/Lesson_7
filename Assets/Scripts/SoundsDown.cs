using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsDown : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClips;

    public GameObject SoundUp;
    public GameObject SoundDown;


    private void OnTriggerEnter(Collider other)
    {
        int index = Random.Range(0, 3);
        audioSource.clip = audioClips[index];
        audioSource.Play();
        SoundUp.SetActive(true);
        SoundDown.SetActive(false);
    }
}
