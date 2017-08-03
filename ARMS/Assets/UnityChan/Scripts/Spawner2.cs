using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour {
	public GameObject HPcubu;
	public Vector3 Hose;
	public Vector3 Hose2;
	private int n;
	private Animator anim;
	private AnimatorStateInfo currentState;		
	private AnimatorStateInfo previousState;

	// Use this for initialization
	void Start () {
		n = 50;
		anim = GetComponent<Animator> ();
		currentState = anim.GetCurrentAnimatorStateInfo (0);
		previousState = currentState;

		for (int i = n; i > 0; i--) {
			Instantiate (HPcubu, transform.position + (Hose*i) + Hose2 , transform.rotation);
		}


	}
	
	// Update is called once per frame
	void Update () {
			
		for (int i = n; i > 0; i--) {
			Instantiate (HPcubu, transform.position + (Hose*i) + Hose2 , transform.rotation);
		}

		Debug.Log (n);
		if (n <= 0) {
			anim.SetBool ("Next00", true);
		}



	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "1PTama") {
			n--;
		}
	}

}
