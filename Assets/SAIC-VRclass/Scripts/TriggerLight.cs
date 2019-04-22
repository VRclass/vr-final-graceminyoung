using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLight : MonoBehaviour {
	public Light ligthToSwitch = null;

	public void OnTriggerEnter(Collider other) {
		ligthToSwitch.enabled = false ;
		print ("entered the trigger");
	}

	public void OnTriggerExit(Collider other){
		ligthToSwitch.enabled = true;
	}
}