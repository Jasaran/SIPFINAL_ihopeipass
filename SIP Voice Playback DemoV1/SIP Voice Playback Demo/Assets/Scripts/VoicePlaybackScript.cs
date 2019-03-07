using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoicePlaybackScript : MonoBehaviour {

   private AudioSource rAudio;
    private string device;

    public bool loopRecord;
    public int recordTime;

    void Start ()
    {
           rAudio = gameObject.GetComponent<AudioSource>();
        device = Microphone.devices[0];
        Debug.Log(device);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Recording");
            rAudio.clip = Microphone.Start(device, loopRecord, recordTime, 44100);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            rAudio.Play();
        }
        
    }
}
