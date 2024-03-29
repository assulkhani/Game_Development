﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	Rigidbody myRigibody;

	[SerializeField] float moveSpeed;
	[SerializeField] float jumpPower;
	float hInput;
	float vInput;
	bool jumpInput;

	void Awake(){
		myRigibody = GetComponent<Rigidbody> ();
	}

	void Update(){
		hInput = Input.GetAxis ("Horizontal") * moveSpeed;
		vInput = Input.GetAxis ("Vertical") *moveSpeed;
		jumpInput = Input.GetKeyDown (KeyCode.Space);
	}

	void FixedUpdate(){
		Move ();
		 
		if(jumpInput){
			Jump();
			jumpInput = false;

		}
	}
	void Move(){
		myRigibody.AddForce (hInput * Time.fixedDeltaTime, 0f, vInput * Time.fixedDeltaTime);
	}

	void Jump(){
		myRigibody.AddForce (Vector3.up * jumpPower * Time.fixedDeltaTime,  ForceMode.Impulse);
	}


}
