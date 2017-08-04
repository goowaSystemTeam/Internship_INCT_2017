using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

	public GameObject bulletPrefab;
	public Vector3 Hose;
	public Vector3 Renketsu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Jump")) {
			
				Instantiate (bulletPrefab, transform.position + Hose , transform.rotation);

		}
	}
}
