using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Banshee : CovenantVehicle
    {
        public Banshee()
        {
            this.NumPassengers = 1;
            this.Weapon = new PlasmaRepeater();
            this.Movement = "fly";
        }
    }
}