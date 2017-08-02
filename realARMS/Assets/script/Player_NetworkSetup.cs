using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Player_NetworkSetup : NetworkBehaviour {
	[SerializeField]Camera FPSCharactorCam;
	[SerializeField]AudioListener audioListener;

	// Use this for initialization
	void Start () {
		if (isLocalPlayer) {
			GameObject.Find ("Scene Camera").SetActive (false);
			GetComponent<CharacterController> ().enabled = true;
			GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController> ().enabled = true;
			FPSCharactorCam.enabled = true;
			audioListener.enabled = true;
		}
	}
}
