﻿using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	public float moveSpeed = 10f;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.forward * Time.deltaTime * moveSpeed);
	}
}
