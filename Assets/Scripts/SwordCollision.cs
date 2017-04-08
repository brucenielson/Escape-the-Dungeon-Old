using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordCollision : MonoBehaviour {
	private Animator anim;

	// We just collided with an object
	private void OnTriggerEnter(Collider collider) {
		int layer = collider.gameObject.layer;
		anim = this.GetComponentInParent<Animator> ();
		//Debug.Log (anim.ToString ());
		if (layer != LayerMask.NameToLayer ("Floor") && layer != LayerMask.NameToLayer ("Monster")) {
			Debug.Log ("Sword Hit something:" + collider.name.ToString());
			Debug.Log (LayerMask.LayerToName(layer));

			anim.SetBool ("isIdle", false);
			anim.SetBool ("isWalking", false);
			anim.SetBool ("isAttacking", false);
			anim.SetBool ("Hit", true);
		}
	}
		
}
