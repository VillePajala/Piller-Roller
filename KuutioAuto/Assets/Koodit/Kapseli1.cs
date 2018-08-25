using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kapseli1 : MonoBehaviour {


    private GameObject naytto = null;
    

    // Use this for initialization
    void Start () {
        this.naytto = GameObject.Find("Lattia");
        
    }
	
	// Update is called once per frame
	void Update () {

        if (this.GetComponent<Transform>().position.y < 0)
        {

            this.naytto.GetComponent<Pistelaskuri>().pisteet += 1;
            enabled = false;
        }
    }
}
