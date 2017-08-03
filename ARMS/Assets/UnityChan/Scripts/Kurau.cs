using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kurau : MonoBehaviour {

	private Animator anim;
	private AnimatorStateInfo currentState;	
	private AnimatorStateInfo previousState;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other){
		Debug.Log (other.gameObject.tag);
		if (other.gameObject.tag == "1PTama") {
			anim.SetTrigger ("Next");
		}

	

	}

}
