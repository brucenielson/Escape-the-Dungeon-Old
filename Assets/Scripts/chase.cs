using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chase : MonoBehaviour {

	public Transform player;
	static Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log ("Start Update");
		Vector3 direction = player.position - this.transform.position;
		//Debug.Log ("Distance: " + direction.magnitude.ToString ());
		float angle = Vector3.Angle (direction, this.transform.forward);
		//Debug.Log ("Angle: " + angle.ToString ());
		//Debug.Log(anim.GetCurrentAnimatorStateInfo(0).IsName("Attack"));
		if (Vector3.Distance (player.position, this.transform.position) < 10 && angle < 75 && anim.GetCurrentAnimatorStateInfo(0).IsName("Attack") == false) {
			
			direction.y = 0;
			this.transform.rotation = Quaternion.Slerp (this.transform.rotation, 
				Quaternion.LookRotation (direction), 0.1f);

			anim.SetBool ("isIdle", false);
			if (direction.magnitude > 2) {
				this.transform.Translate (0, 0, 0.03f);
				anim.SetBool ("isWalking", true);
				anim.SetBool ("isAttacking", false);
			} else {
				anim.SetBool ("isAttacking", true);
				anim.SetBool ("isWalking", false);
			}
		} else {
			anim.SetBool ("isIdle", true);
			anim.SetBool ("isWalking", false);
			anim.SetBool ("isAttacking", false);
		}
	}
}
