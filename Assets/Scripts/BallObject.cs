using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallObject : MonoBehaviour {

	public AudioSource audioSource;

	void Start(){
		audioSource = GetComponent<AudioSource> ();
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.relativeVelocity.magnitude > .01)
			audioSource.Play ();
	}

	/**
	void onCollisionEnter (Collision col) {
		print ("Detected collision btwn" + gameObject.name + " and " + col.collider.name);
		Debug.Log ("GAME OBJECT" + col.gameObject.name);
		if (col.gameObject.name == "Ball") {
			Debug.Log ("Play audio here");
		}
	}

	void Awake() {
		print ("Ball object script woke");
	}
	*/

}
