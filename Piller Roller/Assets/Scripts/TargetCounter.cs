using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TargetCounter : MonoBehaviour {

    Vector3 destination = new Vector3(0f, 12f, 0f);
    Vector3 location;
    public int points = 0;
    float step = 0.1f;

    GameObject gameinfo = null;
    GameObject gameinfo2 = null;
    GameObject pointcounter = null;
    GameObject plane = null;
    GameObject player = null;

  
    void Start () {   
     
        this.pointcounter = GameObject.Find("TargetCounter");
        this.gameinfo = GameObject.Find("Main");
        this.gameinfo2 = GameObject.Find("Main3");
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
            this.gameinfo2.GetComponent<Text>().text = "Press Space for next Level or R to Replay";

            this.pointcounter.GetComponent<Text>().text = "" + this.points + "/6";

            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(2);
            } // if




        } // else
        
	} // Update

    
    
} // Class
