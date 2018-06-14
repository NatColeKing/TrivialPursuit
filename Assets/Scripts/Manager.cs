using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {
	int scene = 0;
	public AudioSource music = GameObject.Find("Music").GetComponent<AudioSource>();
	void Start (){
		DontDestroyOnLoad(this.gameObject);
	}

	// Update is called once per frame
	void Update (){
		Debug.Log("Scene = " + scene);
		Debug.Log("Time = " + Time.timeSinceLevelLoad);

		//music.PlayDelayed(7);
		if(scene == 6){
			if(Time.timeSinceLevelLoad > 11){
				SceneManager.LoadScene("07 - Credits");
				scene = 7;
			}
		}
		if(scene == 5){
			if(Time.timeSinceLevelLoad > 61){
				SceneManager.LoadScene("06 - End");
				scene = 6;
			}
		}
		if(scene == 4){
			if(Time.timeSinceLevelLoad > 4.5){
				SceneManager.LoadScene("05 - Stomp to fight");
				scene = 5;
			}
		}
		if(scene == 3){
			if(Time.timeSinceLevelLoad > 20){
				SceneManager.LoadScene("04 - Blackout");
				scene = 4;
			}
		}
		if(scene == 2){
			if(Time.timeSinceLevelLoad > 11.5){
				SceneManager.LoadScene("03 - Trip and Cry");
				scene = 3;
			}
		}
		if(scene == 1){
			// music.Play();
			if(Time.timeSinceLevelLoad > 8.5){
				SceneManager.LoadScene("02 - Running");
				scene = 2;
			}
		}
		if(scene == 0){
			music.Play();
			if(Time.timeSinceLevelLoad > 8){
				SceneManager.LoadScene("01 - Intro Running");
				scene = 1;
			}
		}
	}
}
