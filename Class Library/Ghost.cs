using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Ghost : CovenantVehicle
    {
        public Ghost()
        {
            this.NumPassengers = 1;
            this.Weapon = new PlasmaRepeater();
            this.Movement = "high-speed hover";
        }
    }
}