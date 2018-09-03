using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Kamikaze.Games
{

    public class PlayerFunctions
    {
        private float speed = 0f;
        private float rotation = 0f;
        

        public PlayerFunctions(string direction, float speed, float rotation)
        {
            this.SetSpeed(direction, speed, rotation);
        } // PlayerFunctions

        public void SetSpeed(string direction, float speed, float rotation)
        {
            if (direction.Equals("forward"))
            {
                this.speed = speed;
            } // if
            else if (direction.Equals("back"))
            {
                this.speed = speed * -1f;
            } // if
            else if (direction.Equals("right"))
            {
                this.rotation = rotation;
            } // if
            else if (direction.Equals("left"))
            {
                this.rotation = rotation * -1f;
            } // if
        } // SetSpeed


        public float GetSpeed()
        {
            return speed;
        } // GetSpeed

        public float GetRotation()
        {
            return rotation;
        } // GetRotation


    } //class

} //namespace


