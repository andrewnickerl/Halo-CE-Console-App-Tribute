using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Spirit : CovenantVehicle
    {
        public Spirit()
        {
            this.NumPassengers = 20;
            this.Weapon = new PlasmaRepeater();
            this.Movement = "fly";
        }
    }
}