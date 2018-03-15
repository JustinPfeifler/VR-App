﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViveControllerInputTest : MonoBehaviour
{

	private SteamVR_TrackedObject trackedObj;

	private SteamVR_Controller.Device Controller {
		get { return SteamVR_Controller.Input ((int)trackedObj.index); }
	}

	void Awake ()
	{
		trackedObj = GetComponent<SteamVR_TrackedObject> ();
	}

	// Update is called once per frame
	void Update ()
	{
		// Get the position of the finger when it's on the touchpad
		if (Controller.GetAxis () != Vector2.zero) {
			Debug.Log (gameObject.name + Controller.GetAxis ());
		}

		// Trigger Down
		if (Controller.GetHairTriggerDown ()) {
			Debug.Log (gameObject.name + " Trigger Press");
		}

		// Trigger Release
		if (Controller.GetHairTriggerUp ()) {
			Debug.Log (gameObject.name + " Trigger Release");
		}

		// Grip Press
		if (Controller.GetPressDown (SteamVR_Controller.ButtonMask.Grip)) {
			Debug.Log (gameObject.name + "Grip Press");
		}

		// Grip press release
		if (Controller.GetPressUp (SteamVR_Controller.ButtonMask.Grip)) {
			Debug.Log (gameObject.name + " Grip Release");
		}
	}
}