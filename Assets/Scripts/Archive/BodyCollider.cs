//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Collider dangling from the player's head
//
//=============================================================================

using UnityEngine;
using System.Collections;

//-------------------------------------------------------------------------
[RequireComponent( typeof( CapsuleCollider ) )]
public class BodyCollider : MonoBehaviour
{
	public Transform head;
	public int playerLayer;

	private CapsuleCollider capsuleCollider;

	//-------------------------------------------------
	void Awake()
	{
		capsuleCollider = GetComponent<CapsuleCollider>();
	}


	//-------------------------------------------------
	void FixedUpdate()
	{

		RaycastHit hit;
		int layerMask = 1 << playerLayer;

		// Ray cast to floor ignoring player
		if (Physics.Raycast (head.transform.position, Vector3.down, out hit, 10, ~layerMask)) {
			//print ("Hit this object: " + hit.collider.gameObject.name);	
			//print ("Found an object - distance: " + hit.distance);
		
			// shortern the body collider if you are nearing to the ground
			float distanceFromFloor = hit.distance;
			capsuleCollider.height = distanceFromFloor; 
			//Debug.Log ("Distance from Floor: " + distanceFromFloor.ToString());
			//Debug.Log ("height: " + capsuleCollider.height.ToString());

			// Rotate body colider so it's always pointing down
			Vector3 bodyRotation;
			//Debug.Log("Current Head Rotation: " + head.eulerAngles.ToString());
			bodyRotation.x = 180.0f;
			bodyRotation.y = 0.0f; //head.eulerAngles.y;
			bodyRotation.z = 0.0f;
			capsuleCollider.transform.eulerAngles = bodyRotation;

		}
	}
}
