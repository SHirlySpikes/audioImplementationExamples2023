using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdPracticeScript : MonoBehaviour
{
    AudioSource myAudioSource;
    [Range(0f, 1f)]  public float myVolume;
    
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        myAudioSource.pitch = Random.Range(0.1f, 1f);
    }
}
