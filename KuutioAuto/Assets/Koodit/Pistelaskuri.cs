using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pistelaskuri : MonoBehaviour {
    Vector3 paate = new Vector3(0f, 6f, 0f);
    Vector3 sijainti;
    public int pisteet = 0;
    float step = 0.1f;
    



    
    GameObject pisteteksti2 = null;
    GameObject taso = null;
    GameObject auto = null;
    // GameObject aika = null;


    // Use this for initialization
    void Start () {
        
        
        this.pisteteksti2 = GameObject.Find("Pistelaskuri2");
        
        this.taso = GameObject.Find("Lattia");
        this.auto = GameObject.Find("Ajoneuvo");
        
    }
	
	// Update is called once per frame
	void Update () {

    if(pisteet < 6)
    {
            
            this.pisteteksti2.GetComponent<Text>().text = "POINTS:" +  this.pisteet;
        }
    else
        {
            this.taso.GetComponent<Rigidbody>().isKinematic = false;
            this.auto.GetComponent<Rigidbody>().isKinematic = true;
            this.auto.GetComponent<AjoneuvoOhjaus1>().enabled = false;
            sijainti = this.auto.GetComponent<Transform>().position;
            this.auto.GetComponent<Transform>().position = Vector3.MoveTowards(sijainti, paate, step);
            this.auto.GetComponent<Transform>().Rotate(1f, 1f, 1f);

            

            this.pisteteksti2.GetComponent<Text>().text = "TOTAL POINTS: " + this.pisteet;
            
        }
        
	}

    
    
}
