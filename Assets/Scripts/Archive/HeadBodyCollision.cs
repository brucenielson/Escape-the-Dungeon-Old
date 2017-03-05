using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadBodyCollision : MonoBehaviour {

	// We just collided with an object
	private void OnTriggerEnter(Collider collider) {
		Debug.Log ("Hit head or body");
	}
}
