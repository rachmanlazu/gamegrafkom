using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TembakBolaApi : MonoBehaviour {

	public float damage;
	public float kecepatan;

	Rigidbody myRB;


	// Use this for initialization
	void Start () {
		myRB = GetComponentInParent<Rigidbody> ();

		if (transform.rotation.y > 0)
			myRB.AddForce (Vector3.left * kecepatan, ForceMode.Impulse);
		else
			myRB.AddForce (Vector3.left * -kecepatan, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.layer == LayerMask.NameToLayer ("Menembak")) {
			myRB.velocity = Vector3.zero;
			Destroy (gameObject);
		}
	}
}
