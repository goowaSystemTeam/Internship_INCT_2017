using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour {

	public GameObject bulletPrefab;
	public Vector3 Hose;
	public Vector3 Renketsu;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire3")) {
			for (int i = 0; i < 10; i++) {
				Instantiate (bulletPrefab, transform.position + Hose + Renketsu*i, transform.rotation);
			}
		}
	}
}
