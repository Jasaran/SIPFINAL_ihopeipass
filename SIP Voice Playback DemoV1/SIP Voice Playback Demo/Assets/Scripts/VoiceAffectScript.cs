using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceAffectScript : MonoBehaviour
{
    
    GameObject varGameObject = GameObject.Find("sound Record/Playback");

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object Entered the trigger");
        varGameObject.SetActive(false);
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("object is within the trigger");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Object has exited the trigger");
        varGameObject.SetActive(true);
    }

}
