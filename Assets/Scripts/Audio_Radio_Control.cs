using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Radio_Control : MonoBehaviour
{
    private AudioSource radioAudioSource;
    public AudioClip clip01;
    public AudioClip clip02;
    public AudioClip clip03;

    // Start is called before the first frame update
    void Start()
    {
        radioAudioSource = GetComponent<AudioSource>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (radioAudioSource.clip == clip01)
        {
            radioAudioSource.clip = clip02;
        }
        else if(radioAudioSource.clip == clip02)
        {
            radioAudioSource.clip = clip03;
        }


        //radioAudioSource.clip = clip01;
        radioAudioSource.Play();
    }
}
