using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Pelican : HumanVehicle
    {
        public Pelican()
        {
            this.NumPassengers = 10;
            this.Weapon = null;
            this.Movement = "fly";
        }
    }
}