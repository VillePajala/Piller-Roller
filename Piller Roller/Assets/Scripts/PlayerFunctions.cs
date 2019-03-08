using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Kamikaze.Games {

    public class PlayerFunctions {

        private float speed = 0f;
        private float rotation = 0f;


        public PlayerFunctions(string direction, float speed, float rotation) {
            this.SetSpeed(direction, speed, rotation);
        } 

        public void SetSpeed(string direction, float speed, float rotation) {
            if (direction.Equals("forward")) {
                this.speed = speed;
            } else if (direction.Equals("back")) {
                this.speed = speed * -1f;
            } else if (direction.Equals("right")) {
                this.rotation = rotation;
            } else if (direction.Equals("left")) {
                this.rotation = rotation * -1f;
            } 
        } 

        public float GetSpeed() {
            return speed;
        } 

        public float GetRotation() {
            return rotation;
        } 
        
    } 

} 


