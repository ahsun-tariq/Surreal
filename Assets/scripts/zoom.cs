using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoom : MonoBehaviour {

    public Camera cam;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(1))
        {

            cam.fieldOfView = 40;

        }

        if (Input.GetMouseButtonUp(1))
        {

            cam.fieldOfView = 60;

        }
    }
}
