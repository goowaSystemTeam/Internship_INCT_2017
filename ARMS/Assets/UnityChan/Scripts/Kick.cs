using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kick : MonoBehaviour {


	public float speed;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 0.08f);
	}

	// Update is called once per frame
	void Update () {
		transform.localScale = new Vector3 (5, 5, 45);
	}
}
