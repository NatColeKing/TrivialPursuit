using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Manager : MonoBehaviour {
	int scene = 1;
	float timer = 0;
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		timer = Time.timeSinceLevelLoad;
		// Invoke("sceneLoad()", 13);
		Debug.Log("Timer = " + timer);
		Debug.Log("Scene = " + scene);
		if(scene == 1)
		{
			if(timer > 13)
			{
				scene++;
				timer = 0;
				SceneManager.LoadScene("02 - Trip and Cry");
			}
		}
		if(scene == 2)
		{
			if(timer > 4)
			{
				scene++;
				timer = 0;
				SceneManager.LoadScene("03 - Blackout");
			}
		}
		// Application.Quit();
	}

	// void sceneLoad()
	// {
	// 	SceneManager.LoadScene((String)sceneTrack);
	// 	sceneTrack++;
	// }
}
