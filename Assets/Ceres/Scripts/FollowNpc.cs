﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowNpc : MonoBehaviour {

	public GameObject attractor;

	public float speed;

	private Vector3 attractionPoint;


	void Update () {
		attractionPoint = attractor.transform.position; //Update our attraction point every frame
		this.GetComponent<Rigidbody> ().AddForce ((attractionPoint - transform.position).normalized * speed); //Add force towards the target AKA gravity
	}

}
