﻿using UnityEngine;
using System.Collections;

public class Crane : MonoBehaviour {
	public bool swing;

	private Animator anim;
	private GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		anim = GetComponent<Animator>();

	}
	void OnTriggerEnter(Collider other){
		anim.SetBool ("swing", true);
	}
	void OnTriggerExit(Collider other){
		anim.SetBool ("swing", false);
	}

}
