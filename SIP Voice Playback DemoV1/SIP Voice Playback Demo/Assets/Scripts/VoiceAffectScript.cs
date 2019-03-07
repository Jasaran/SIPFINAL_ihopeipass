using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceAffectScript : MonoBehaviour
{
    private Component mycompComponent;

    void start()
    {
        mycompComponent = GetComponent<VoicePlaybackScript>();
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object Entered the trigger");
       // mycompComponent.enabled = false;
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("object is within the trigger");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Object has exited the trigger");
        //mycompComponent.enabled = true;
    }

}
