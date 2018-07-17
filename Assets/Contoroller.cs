using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contoroller : MonoBehaviour {
	
	Rigidbody rb;

	public float speed = 2f;
	public float thrust = 100;
	private Animator animator;


	public void Hit(){
	}

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () { 


		


		Input.GetAxis ("Horizontal_1");
		Input.GetAxis ("Vertical 1");
		


			if(Input.GetKey(KeyCode.Joystick1Button10)){
				animator.SetBool("Junnping",true);
				rb.AddForce(new Vector3(0,thrust,0));
				
			}
			else{
				animator.SetBool("Junnping",false);
			}
	}

}
