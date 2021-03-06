﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCamera : MonoBehaviour {
    public Camera camera1;
    public Camera camera2;
	// Use this for initialization
	void Start () {
        camera1.enabled = true;
        camera1.GetComponent<AudioListener>().enabled = true;
        camera2.enabled = false;
        camera2.GetComponent<AudioListener>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.C))
        {
            camera1.enabled = !camera1.enabled;
            camera1.GetComponent<AudioListener>().enabled = !camera1.GetComponent<AudioListener>().enabled;
            camera2.enabled = !camera2.enabled;
            camera2.GetComponent<AudioListener>().enabled = !camera2.GetComponent<AudioListener>().enabled;
        }
	}
}
