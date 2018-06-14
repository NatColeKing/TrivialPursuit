using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour {
	public GameObject title;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	// bam whack pow
	void Update () {
		if(Time.timeSinceLevelLoad > 3)
			title.SetActive(true);
		if(Time.timeSinceLevelLoad > 6)
			title.SetActive(false);
	}
}
