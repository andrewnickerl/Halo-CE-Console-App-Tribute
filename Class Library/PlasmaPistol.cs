using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class PlasmaPistol : CovenantWeapon
    {
        public PlasmaPistol()
        {
            this.Accuracy = 80;
            this.BatteryReducedPerUse = 1;
            this.Damage = 15;
        }
    }
}