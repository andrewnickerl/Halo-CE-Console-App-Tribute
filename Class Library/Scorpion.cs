using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Scorpion : HumanVehicle
    {
        public Scorpion()
        {
            this.NumPassengers = 5;
            this.Weapon = new Cannon();
            this.Movement = "roll with tracks";
        }
    }
}