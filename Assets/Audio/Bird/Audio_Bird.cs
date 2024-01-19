using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Bird : MonoBehaviour
{
     public AudioSource birdAudioSource;
    public float birdVolume = 0.5f;
    public float birdPitch = 1f;

    // Start is called before the first frame update
    void Start()
    {
        birdAudioSource.volume = birdVolume;
        //birdAudioSource.pitch = birdPitch;
    }

    void Update()
    {
        //birdAudioSource.pitch = (Random.Range(0.6f, 2f));
    }

    void OnTriggerEnter(Collider other)
    {
        birdAudioSource.Play();
        Debug.Log("Im Touched!");
    }
}
