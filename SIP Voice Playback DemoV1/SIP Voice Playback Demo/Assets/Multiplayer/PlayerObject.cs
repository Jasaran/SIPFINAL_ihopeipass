using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObject : MonoBehaviour {

	// Use this for initialization
	void Start () {



        Debug.Log("PlayerObject::Start -- Spawning my own personal unit.");
        Instantiate(PlayerUnitPrefab);

	}

    public GameObject PlayerUnitPrefab;

	// Update is called once per frame
	void Update () {
		
	}
}
