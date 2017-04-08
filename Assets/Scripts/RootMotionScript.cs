using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]

public class RootMotionScript : MonoBehaviour {

	void OnAnimatorMove()
	{
		Animator animator = GetComponent<Animator>(); 

		if (animator && animator.GetBool("isWalking"))
		{
			this.transform.Translate (0, 0, 0.03f);

			//Vector3 newPosition = transform.position;
			//newPosition.z += animator.GetFloat("Walkspeed") * Time.deltaTime; 
			//transform.position = newPosition;
		}
	}
}

