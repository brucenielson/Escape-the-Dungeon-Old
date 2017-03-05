using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordCollision : MonoBehaviour {

	// We just collided with an object
	private void OnTriggerEnter(Collider collider) {
		Debug.Log ("Sword Hit something:" + collider.name.ToString());
	}
		
}
