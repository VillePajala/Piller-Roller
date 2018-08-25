using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Laskuriteksti : MonoBehaviour {

    public int laskuri = 0;
    public int pojo = 0;

    private GameObject pointsit = null;
    private GameObject tekstiolio2 = null;

    // Use this for initialization
    void Start () {
        this.tekstiolio2 = GameObject.Find("Laskuri2");
        this.pointsit = GameObject.Find("Lattia");
    }
	
	// Update is called once per frame
	void Update () {

        pojo = this.pointsit.GetComponent<Pistelaskuri>().pisteet;

        if(pojo < 6)
        {
            this.laskuri++;
            this.tekstiolio2.GetComponent<Text>().text = "" + this.laskuri;
        }
        else
        {
            this.tekstiolio2.GetComponent<Text>().text = "" + this.laskuri;
        }
        

        
    }

    public int Laskuri()
    {
        return laskuri;
    }
}
