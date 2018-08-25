using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kamikaze.Games;
using UnityEngine.UI;

public class AjoneuvoOhjaus1 : MonoBehaviour {

    private AjoneuvonToiminnallisuus kuutiohallinta = new AjoneuvonToiminnallisuus("", 15f, 150f);
    
    private GameObject teksti = null;
    private GameObject laatikko = null;

	// Use this for initialization
	void Start () {

        this.laatikko = GameObject.Find("Ajoneuvo");
        this.teksti = GameObject.Find("Main");
		
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKey(KeyCode.UpArrow)) {
            this.kuutiohallinta.AsetaEteneminen("eteen", 15f, 150f);
            this.transform.Translate(Vector3.forward * this.kuutiohallinta.GetEtenemisNopeus() * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow)) {
            this.kuutiohallinta.AsetaEteneminen("taakse", 15f, 150f);
            this.transform.Translate(Vector3.forward * this.kuutiohallinta.GetEtenemisNopeus() * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow)) {
            this.kuutiohallinta.AsetaEteneminen("vasen", 15f, 150f);
            this.transform.Rotate(Vector3.up * this.kuutiohallinta.GetKaantymisNopeus() * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            this.kuutiohallinta.AsetaEteneminen("oikea", 15f, 150f);
            this.transform.Rotate(Vector3.up * this.kuutiohallinta.GetKaantymisNopeus() * Time.deltaTime);
        }

        if(this.laatikko.transform.position.y < 0) {
            this.teksti.GetComponent<Text>().color = Color.red;
            this.teksti.GetComponent<Text>().text = "GAME OVER! Press 'R' to play again";
        }


    }


}
