using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unity : MonoBehaviour {
	public Animator animator;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Joystick1Button10)){
			animator.SetTrigger("attack 1");
		}
	}

}
