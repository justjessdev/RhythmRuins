﻿using UnityEngine;
using System.Collections;

public class TrackPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = PlatformerController.main.transform.position;
	}
}
