using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    private Transform vehicle = null;
	
	void Start () {

        this.vehicle = GameObject.Find("Player").transform;

	} // Start
	
	
	void Update () {

        this.transform.LookAt(this.vehicle);
		
	} // Update
}
