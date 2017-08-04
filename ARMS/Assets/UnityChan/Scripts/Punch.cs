using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour {



	private Animator anim;	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Jump")) {
			transform.localScale = new Vector3 (10, 10, 10);
		}

		if (Input.GetButton ("Jump")==false ) {
			transform.localScale = new Vector3 (1, 1, 1);
		}
	}
}
