using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoicePlaybackScript : MonoBehaviour {

   private AudioSource rAudio;

	void Start ()
    {
           rAudio = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Recording");
            rAudio.clip = Microphone.Start("Blue Snowball", true, 10, 44100);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            rAudio.Play();
        }
        foreach (string device in Microphone.devices)
            Debug.Log(device);
    }
}
