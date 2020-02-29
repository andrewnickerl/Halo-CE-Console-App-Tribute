using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class PlasmaRifle : CovenantWeapon
    {
        public PlasmaRifle()
        {
            this.Accuracy = 70;
            this.BatteryReducedPerUse = 2;
            this.Damage = 25;
        }
    }
}