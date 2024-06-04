using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounder : MonoBehaviour
{
    public float PitchRange = .3f;

    System.Random random = new System.Random();
    AudioSource audioSource;

    public AudioClip audioClip;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();

    }
    private void OnCollisionEnter(Collision collision)
    {
        audioSource.pitch = (float) (1 + 2 * PitchRange * (-.5 + random.NextDouble()));
        audioSource.PlayOneShot(audioClip);
    }
}
