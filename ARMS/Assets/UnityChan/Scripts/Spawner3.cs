using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner3 : MonoBehaviour {
	public GameObject bulletPrefab;
	public Vector3 Hose;
	public Vector3 Renketsu;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {

			Instantiate (bulletPrefab, transform.position + Hose , transform.rotation);

		}
	}
}
