using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour {

	public int playerHP = 1000;


	void Start(){
		
	}

	void Update(){
		if (playerHP == 0){
			Debug.Log ("GameOver");
		}
	}

	void OnTriggerEnter(Collider hit){ 

		if (hit.CompareTag ("Bullet")) {

		}
	}
}