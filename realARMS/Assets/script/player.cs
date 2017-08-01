using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
	public float jumppower = 1.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump")){
			GetComponent<Rigidbody>().velocity = new Vector3 (0,jumppower,0);
		}
	}

	void OnCollisionEnter(Collision other){
		Application.LoadLevel (Application.loadedLevel);
	}
}
