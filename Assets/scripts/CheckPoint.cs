//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;
using System.Collections;

	public class CheckPoint : MonoBehaviour{
	public LevelManager levelManager;
	void Start(){
		levelManager = FindObjectOfType<LevelManager> ();

	}
	void Update(){

	}
	void OnTriggerEnter(Collider other){
		if(other.name == "Player"){
			levelManager.currentCheckpoint = gameObject;
			Debug.Log ("Activated Checkpoint " + transform.position);
		}
	}
	}


