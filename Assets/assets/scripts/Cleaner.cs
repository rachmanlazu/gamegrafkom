﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaner : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			PlayerHealth playerDead = other.gameObject.GetComponent<PlayerHealth> ();
			playerDead.makeDead ();
		} else
			Destroy (gameObject);
	}
}
