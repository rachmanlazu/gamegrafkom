using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApiPeluru : MonoBehaviour {

	public float waktuTiapPeluru = 0.15f;
	public GameObject projectile;

	float nextPeluru;

	// Use this for initialization
	void Awake () {
		nextPeluru = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		playerController pemain = transform.root.GetComponent<playerController> ();

		if (Input.GetAxisRaw ("Fire1") > 0 && nextPeluru < Time.time) {
			nextPeluru = Time.time + waktuTiapPeluru;
			Vector3 rot;
			if (pemain.GetFacing () == -1f) {
				rot = new Vector3 (0, -90, 0);
			} else
				rot = new Vector3 (0, 90, 0);

			Instantiate (projectile, transform.position, Quaternion.Euler (rot));
		}
	}
}
