using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour {

	public Animator animator;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		animator=GetComponent<Animator> ();

		if (Input.GetKeyDown (KeyCode.B)) {
			animator.SetBool ("Attack", true);
		} else {
			animator.SetBool ("Attack", false);
		}

	}
}
