using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	[SerializeField] Transform target;
	[SerializeField] float followSpeed;
	Vector3 offset;

	void Start(){
		offset = target.position - transform.position;
	}


	void FixedUpdate(){
		transform.position = Vector3.Lerp (transform.position, target.position - offset, Time.deltaTime * followSpeed);
	}

}