using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Warthog : HumanVehicle
    {
        public Warthog()
        {
            this.NumPassengers = 3;
            this.Weapon = new Chaingun();
            this.Movement = "roll with wheels";
        }
    }
}