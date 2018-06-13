using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bandit_02_scene04 : MonoBehaviour {

	AudioSource source;
	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Time = " + Time.timeSinceLevelLoad);

		if(Time.timeSinceLevelLoad > 17){
				source.Play();
		}
	}
}
