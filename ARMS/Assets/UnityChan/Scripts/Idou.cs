using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idou : MonoBehaviour {

	public Vector3 addPosition1;
	public Vector3 addPosition2;
	public Quaternion Re;

	// Use this for initialization
	void Start () {
		Re = new Quaternion (0, 1, 0, 180);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("up")) {
			transform.position += addPosition1;
		}

		if (Input.GetKey ("down")) {
			transform.position -= addPosition1;
		}

		if (Input.GetKey ("right")) {
			transform.position += addPosition2;
		}

		if (Input.GetKey ("left")) {
			transform.position -= addPosition2;
		}

		transform.rotation = Re;

	}

	void OnCollisionEnter(Collision other){
		Debug.Log (other.gameObject.tag);
	
	}
}
