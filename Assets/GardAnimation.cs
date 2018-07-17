using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GardAnimation : MonoBehaviour {

	public Animator animator;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		animator = GetComponent<Animator> ();

		if (Input.GetKey (KeyCode.V)) {
			animator.SetBool ("Gard", true);
		} else {
			animator.SetBool ("Gard", false);
		}
	

	}
}
