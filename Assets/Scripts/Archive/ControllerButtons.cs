using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerButtons : MonoBehaviour {
	private Valve.VR.EVRButtonId gripButton = Valve.VR.EVRButtonId.k_EButton_Grip;
	private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;
	private Valve.VR.EVRButtonId touchPad = Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad;
	private Valve.VR.EVRButtonId dPadUp = Valve.VR.EVRButtonId.k_EButton_DPad_Up;
	private Valve.VR.EVRButtonId dPadDown = Valve.VR.EVRButtonId.k_EButton_DPad_Down;
	private Valve.VR.EVRButtonId dPadRight = Valve.VR.EVRButtonId.k_EButton_DPad_Right;
	private Valve.VR.EVRButtonId dPadLeft = Valve.VR.EVRButtonId.k_EButton_DPad_Left;
	private Valve.VR.EVRButtonId menuButton = Valve.VR.EVRButtonId.k_EButton_ApplicationMenu;

	private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }
	private SteamVR_TrackedObject trackedObj;


	public Transform head;
	public GameObject camera;


	// Use this for initialization
	void Start () {
		trackedObj = GetComponent<SteamVR_TrackedObject>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		// If the player presses down on the touch pad (on the upper half?), start moving
		if (controller.GetPress(touchPad)) { //&& controller.GetAxis().y > 0.5f) {
			//Debug.Log ("pressing touch pad down");
			//Debug.Log ("Axis is: " + controller.GetAxis ().ToString ());

			// tranform position approach
			Vector3 dir = transform.position - head.position;
			dir.y = 0;
			camera.transform.position += (dir/10.0f);


			// velocity approach
			//Vector3 dir = transform.
		}	
	}


}
