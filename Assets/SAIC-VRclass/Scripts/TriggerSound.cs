using UnityEngine;
using System.Collections;

//[RequireComponent(typeof(AudioSource))]

public class TriggerSound : MonoBehaviour {
	private AudioSource audio;
	public AudioClip clip;

	void Awake(){
		audio = GetComponent<AudioSource> ();
	}

	void OnTriggerEnter(Collider other){
		//This will play without any testing
//		audio.Play();

		//This will play only if the player collides with the trigger
		if (other.tag == "Player"){
			audio.Play ();
			Debug.Log("trigger entered & played sound: "+clip);
		}
	}
}
