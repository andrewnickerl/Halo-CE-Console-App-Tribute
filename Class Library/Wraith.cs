using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Wraith : CovenantVehicle
    {
        public Wraith()
        {
            this.NumPassengers = 3;
            this.Weapon = new PlasmaCannon();
            this.Movement = "slow-speed hover";
        }
    }
}