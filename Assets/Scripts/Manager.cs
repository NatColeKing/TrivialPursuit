using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		if(Time.time > 13)
		{
			SceneManager.LoadScene("02 - Trip and Cry");
		}
		// if(Time.time > 17)
		// {
		// 	UnityEditor.EditorApplication.isPlaying = false;
		// }
		// Application.Quit();

	}
}
