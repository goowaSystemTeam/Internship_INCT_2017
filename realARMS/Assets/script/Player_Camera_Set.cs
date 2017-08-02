using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Camera_Set : MonoBehaviour {
	[Range(0.1f,10.0f)]public float parallax = 1.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnValidate(){
		var position = new Vector3 (parallax, 0, 0);
		GameObject.Find ("FPCamL").transform.localPosition = -position;
		GameObject.Find ("FPCamR").transform.localPosition = position;
	}
}
