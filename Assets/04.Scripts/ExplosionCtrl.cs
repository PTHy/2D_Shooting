using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionCtrl : MonoBehaviour {

	public AudioClip sfx;
	public AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource.PlayOneShot (sfx, 0.9f);
		Invoke ("destroy", 0.75f);
	}
	
	// Update is called once per frame
	void destroy () {
		Destroy (this.gameObject);
	}
}
