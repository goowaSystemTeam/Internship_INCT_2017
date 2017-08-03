using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idou2 : MonoBehaviour {

	private Animator anim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector3 position = new Vector3 (Random.Range (-5f, 5f) * Time.deltaTime, 0, Random.Range (-5f, 5f) * Time.deltaTime);


			transform.position += position;
	}
}
