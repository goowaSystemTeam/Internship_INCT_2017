using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Player_NetworkSetup : NetworkBehaviour {
	[SerializeField]AudioListener audioListener;
	[SerializeField]Camera FPCam;

	// Use this for initialization
	void Start () {
		if (isLocalPlayer) {
			GameObject.Find ("Scene Camera").SetActive (false);
			GameObject.Find ("FirstPersonCharacter/FPCamL").GetComponent<Camera> ().enabled = true;
			GameObject.Find ("FirstPersonCharacter/FPCamR").GetComponent<Camera> ().enabled = true;
			GetComponent<CharacterController> ().enabled = true;
			GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController> ().enabled = true;
			audioListener.enabled = true;
			FPCam.enabled = true;
		}
	}
}
