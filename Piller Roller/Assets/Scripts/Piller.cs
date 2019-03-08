using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piller : MonoBehaviour {

    private GameObject screen = null;
   

    void Start () {
        this.screen = GameObject.Find("Plane");
    } 
	
	void Update () {

        if (this.GetComponent<Transform>().position.y < 0) {
            this.screen.GetComponent<TargetCounter>().points += 1;
            Destroy(this.gameObject, 10);
            enabled = false;
        }
    } 

} 
