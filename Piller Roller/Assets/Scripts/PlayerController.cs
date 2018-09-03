using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kamikaze.Games;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    private PlayerFunctions playerfunctionality = new PlayerFunctions("", 15f, 150f);
    
    private GameObject text = null;
    private GameObject player = null;

	
	void Start () {

        this.player = GameObject.Find("Player");
        this.text = GameObject.Find("Main2");
		
	} // Start
	
	void Update () {

        if(Input.GetKey(KeyCode.UpArrow)) {
            this.playerfunctionality.SetSpeed("forward", 15f, 150f);
            this.transform.Translate(Vector3.forward * this.playerfunctionality.GetSpeed() * Time.deltaTime);
        } // if

        if(Input.GetKey(KeyCode.DownArrow)) {
            this.playerfunctionality.SetSpeed("back", 15f, 150f);
            this.transform.Translate(Vector3.forward * this.playerfunctionality.GetSpeed() * Time.deltaTime);
        } // if

        if (Input.GetKey(KeyCode.LeftArrow)) {
            this.playerfunctionality.SetSpeed("left", 15f, 150f);
            this.transform.Rotate(Vector3.up * this.playerfunctionality.GetRotation() * Time.deltaTime);
        } // if

        if (Input.GetKey(KeyCode.RightArrow)) {
            this.playerfunctionality.SetSpeed("right", 15f, 150f);
            this.transform.Rotate(Vector3.up * this.playerfunctionality.GetRotation() * Time.deltaTime);
        } // if

        if (this.player.transform.position.y < 0) {
            this.text.GetComponent<Text>().color = Color.red;
            this.text.GetComponent<Text>().text = "GAME OVER! Press 'R' to play again";
        } // if

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                this.text.GetComponent<Text>().text = "Paused";
            }

            else
            {
                Time.timeScale = 1;
                this.text.GetComponent<Text>().text = "";
            }



        } // if


    } // Update


} // Class
