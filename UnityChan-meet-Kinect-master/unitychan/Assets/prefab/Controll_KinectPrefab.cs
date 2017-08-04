using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controll_KinectPrefab : MonoBehaviour {
	public GameObject prefab;
	// Use this for initialization
	void Start () {
		Instantiate (prefab);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
