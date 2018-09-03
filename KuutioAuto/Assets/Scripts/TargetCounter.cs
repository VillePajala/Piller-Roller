using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetCounter : MonoBehaviour {

    Vector3 destination = new Vector3(0f, 8f, 0f);
    Vector3 location;
    public int points = 0;
    float step = 0.1f;

    GameObject gameinfo = null;
    GameObject pointcounter = null;
    GameObject plane = null;
    GameObject player = null;
  
    void Start () {   
     
        this.pointcounter = GameObject.Find("TargetCounter");
        this.gameinfo = GameObject.Find("Main");
        this.plane = GameObject.Find("Plane");
        this.player = GameObject.Find("Player");
        
    } // Start
	

	void Update () {

        if (points < 6)
        { 
            this.pointcounter.GetComponent<Text>().text = "" + this.points + "/6";
        } // if
        else
        {
            this.plane.GetComponent<Rigidbody>().isKinematic = false;
            this.player.GetComponent<Rigidbody>().isKinematic = true;
            this.player.GetComponent<PlayerController>().enabled = false;

            location = this.player.GetComponent<Transform>().position;
            this.player.GetComponent<Transform>().position = Vector3.MoveTowards(location, destination, step);
            this.player.GetComponent<Transform>().Rotate(1f, 1f, 1f);

            this.gameinfo.GetComponent<Text>().text = "LEVEL CLEARED!";

            this.pointcounter.GetComponent<Text>().text = "" + this.points + "/6";
            
        } // else
        
	} // Update

    
    
} // Class
