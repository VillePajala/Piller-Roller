using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Kamikaze.Games
{

    public class AjoneuvonToiminnallisuus
    {
        private float etenemisnopeus = 0f;
        private float kaantymisnopeus = 0f;
        

        public AjoneuvonToiminnallisuus(string suunta, float etenemisnopeus, float kaantymisnopeus)
        {
            this.AsetaEteneminen(suunta, etenemisnopeus, kaantymisnopeus);
            
        }

        public void AsetaEteneminen(string suunta, float etenemisnopeus, float kaantymisnopeus)
        {
            if (suunta.Equals("eteen"))
            {
                this.etenemisnopeus = etenemisnopeus;
            }
            else if (suunta.Equals("taakse"))
            {
                this.etenemisnopeus = etenemisnopeus * -1f;
            }
            else if (suunta.Equals("oikea"))
            {
                this.kaantymisnopeus = kaantymisnopeus;
            }
            else if (suunta.Equals("vasen"))
            {
                this.kaantymisnopeus = kaantymisnopeus * -1f;
            }
        }


        public float GetEtenemisNopeus()
        {
            return etenemisnopeus;
        }

        public float GetKaantymisNopeus()
        {
            return kaantymisnopeus;
        }





    } //class

} //namesspace


