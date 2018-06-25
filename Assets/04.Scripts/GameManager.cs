using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static int score = 0;

	void Awake() {
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
		Screen.SetResolution (600, 1024, true);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
