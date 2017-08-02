using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	public GameObject Ref;
	public GameObject Hips;
	public GameObject LeftUpLeg;
	public GameObject LeftLeg;
	public GameObject RightUpLeg;
	public GameObject RightLeg;
	public GameObject Spine1;
	public GameObject Spine2;
	public GameObject LeftShoulder;
	public GameObject LeftArm;
	public GameObject LeftForeArm;
	public GameObject LeftHand;
	public GameObject RightShoulder;
	public GameObject RightArm;
	public GameObject RightForeArm;
	public GameObject RightHand;
	public GameObject Neck;
	public GameObject Head;
	// Use this for initialization
	void Start () {
		
		Ref = 
			_UnityChan.transform.FindChild( "Character1_Reference" ).gameObject;
		Hips = 
			Ref.gameObject.transform.FindChild( "Character1_Hips" ).gameObject;
		LeftUpLeg = 
			Hips.transform.FindChild( "Character1_LeftUpLeg" ).gameObject;
		LeftLeg = 
			LeftUpLeg.transform.FindChild( "Character1_LeftLeg" ).gameObject;
		RightUpLeg = 
			Hips.transform.FindChild( "Character1_RightUpLeg" ).gameObject;
		RightLeg = 
			RightUpLeg.transform.FindChild( "Character1_RightLeg" ).gameObject;
		Spine1 = 
			Hips.transform.FindChild( "Character1_Spine" ).gameObject.
			transform.FindChild( "Character1_Spine1" ).gameObject;
		Spine2 = 
			Spine1.transform.FindChild( "Character1_Spine2" ).gameObject;
		LeftShoulder = 
			Spine2.transform.FindChild( "Character1_LeftShoulder" ).gameObject;
		LeftArm = 
			LeftShoulder.transform.FindChild( "Character1_LeftArm" ).gameObject;
		LeftForeArm = 
			LeftArm.transform.FindChild( "Character1_LeftForeArm" ).gameObject;
		LeftHand = 
			LeftForeArm.transform.FindChild( "Character1_LeftHand" ).gameObject;
		RightShoulder = 
			Spine2.transform.FindChild( "Character1_RightShoulder" ).gameObject;
		RightArm = 
			RightShoulder.transform.FindChild( "Character1_RightArm" ).gameObject;
		RightForeArm = 
			RightArm.transform.FindChild( "Character1_RightForeArm" ).gameObject;
		RightHand = 
			RightForeArm.transform.FindChild( "Character1_RightHand" ).gameObject;
		Neck = 
			Spine2.transform.FindChild( "Character1_Neck" ).gameObject;
		Head = 
			Neck.transform.FindChild( "Character1_Head" ).gameObject;
	// Update is called once per frame
	void Update () {
		
	}
}
