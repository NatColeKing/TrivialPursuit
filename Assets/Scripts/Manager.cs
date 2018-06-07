using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {
	int scene = 0;
	void Start ()
	{
		DontDestroyOnLoad(this.gameObject);
	}

	// Update is called once per frame
	void Update ()
	{
		Debug.Log("Scene = " + scene);
		Debug.Log("Time = " + Time.timeSinceLevelLoad);
		if(scene == 5)
		{
			if(Time.timeSinceLevelLoad > 6)
			{
				// Application.Quit();
			}
		}
		if(scene == 4)
		{
			if(Time.timeSinceLevelLoad > 25)
			{
				SceneManager.LoadScene("05 - End");
				scene = 5;
			}
		}
		if(scene == 3)
		{
			if(Time.timeSinceLevelLoad > 4)
			{
				SceneManager.LoadScene("04 - Stomp to fight");
				scene = 4;
			}
		}
		if(scene == 2)
		{
			if(Time.timeSinceLevelLoad > 20)
			{
				SceneManager.LoadScene("03 - Blackout");
				scene = 3;
			}
		}
		if(scene == 1)
		{
			if(Time.timeSinceLevelLoad > 12)
			{
				SceneManager.LoadScene("02 - Trip and Cry");
				scene = 2;
			}
		}
		if(scene == 0)
		{
			if(Time.timeSinceLevelLoad > 7)
			{
				SceneManager.LoadScene("01 - Running");
				scene = 1;
			}
		}
	}
}
