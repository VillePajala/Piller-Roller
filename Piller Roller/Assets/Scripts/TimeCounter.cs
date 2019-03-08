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
    } 
	
	void Update () {
        score = this.finalscore.GetComponent<TargetCounter>().points;

        if (score < 6 && Time.timeScale == 1) {
            this.counter++;
            this.timecounter.GetComponent<Text>().text = "" + this.counter;
        } else {
            this.timecounter.GetComponent<Text>().text = "" + this.counter;
        }
    } 
   
} 


