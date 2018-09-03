using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour {

    public int counter = 0;
    public int score = 0;

    private GameObject finalscore = null;
    private GameObject timecounter = null;

    
    void Start () {
        this.timecounter = GameObject.Find("TimeCounter");
        this.finalscore = GameObject.Find("Plane");
    } // Start
	
	
	void Update () {

        score = this.finalscore.GetComponent<TargetCounter>().points;

        if(score < 6)
        {
            this.counter++;
            this.timecounter.GetComponent<Text>().text = "" + this.counter;
        } // if
        else
        {
            this.timecounter.GetComponent<Text>().text = "" + this.counter;
        } // else
        
        
    } //Update
   
} // Class
