using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_chirping_sound : MonoBehaviour
{

    AudioSource myAudioSource;
    [Range (0f,1.0f)] public float myVolume = 0.5f;
    public float myMinPitch = 1.0f;
    public float myMaxPitch = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
        myAudioSource.volume = myVolume;
        
    }

    // Update is called once per frame
    void Update()
    {
        //myAudioSource.pitch = Random.Range(myMinPitch, myMaxPitch);
    }

    //Call on collision trigger
    void OnTriggerEnter(Collider other)
    {
        myAudioSource.Play();
    }
}

// float 1.4f 10.0f 0.5f 0f 1.0f
//int 1 5 9 100 