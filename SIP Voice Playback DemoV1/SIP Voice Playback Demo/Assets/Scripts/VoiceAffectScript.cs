using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceAffectScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object Entered the trigger");
    }

    void OntriggerStay(Collider other)
    {
        Debug.Log("object is within the trigger");
    }

    void OntriggerExit(Collider other)
    {
        Debug.Log("Object has exited the trigger");
    }

}
