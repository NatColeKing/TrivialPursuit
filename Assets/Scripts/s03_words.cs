using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class s03_words : MonoBehaviour {
	public GameObject bam;
	public GameObject pow;
	public GameObject whack;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	// bam whack pow
	void Update () {
		if(Time.timeSinceLevelLoad > 1)
			bam.SetActive(true);
		if(Time.timeSinceLevelLoad > 2)
		{
			bam.SetActive(false);
			whack.SetActive(true);
		}
		if(Time.timeSinceLevelLoad > 3)
		{
			whack.SetActive(false);
			pow.SetActive(true);
		}
		if(Time.timeSinceLevelLoad > 4)
			pow.SetActive(false);
	}
}
