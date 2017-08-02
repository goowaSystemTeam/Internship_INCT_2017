﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 1f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, 0, speed * Time.deltaTime);
	}
}
