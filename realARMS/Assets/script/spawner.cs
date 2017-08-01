using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

	public GameObject Wallprefab;
	public float interval;
	public float range = 3.0f;

	// Use this for initialization
	IEnumerator Start () {
		while (true) {
			transform.position = new Vector3 (transform.position.x,
				Random.Range (-range, range),
				transform.position.z);
			Instantiate (Wallprefab, transform.position, transform.rotation);
			yield return new WaitForSeconds (interval);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
