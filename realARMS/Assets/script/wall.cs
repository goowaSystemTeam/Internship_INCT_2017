using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour {
	public float speed = 1.0f;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 10f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (speed * Time.deltaTime, 0, 0);
	}
}
