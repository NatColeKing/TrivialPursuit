// ﻿using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class cameraMove : MonoBehaviour {
//
// 	Vector3[] position;
// 	Quaternion rotation;
// 	float interval;
// 	float intDurr;
// 	int prevState,numStates;
//
// 	// Use this for initialization
// 	void Start () {
// 		intDurr = 1f;
// 		interval = 0;
// 		prevState = 0;
// 		numStates = 3;
// 		position = new Vector3[5];
// 		rotation = new Quaternion[5];
//
// 	}
//
// 	// Update is called once per frame
// 	void Update () {
// 		Debug.Log(Time.time);
// 		if (interval <= Time.time) {
// 			interval = Time.time + intDurr;
// 			transform.position = position[prevState];
// 			transform.rotation = rotation[prevState];
// 			prevState = (prevState + 1)%numStates;
// 	}
// }
// }
