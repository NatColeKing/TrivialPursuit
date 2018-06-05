using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Tears : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		// Debug.Log("Time since load = " + Time.timeSinceLevelLoad);
		if(Time.timeSinceLevelLoad > 5)
		{
			this.gameObject.SetActive(false);
		}
	}
}
