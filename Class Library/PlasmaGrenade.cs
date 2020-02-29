using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class PlasmaGrenade : CovenantWeapon
    {
        public PlasmaGrenade()
        {
            this.Accuracy = 100;
            this.BatteryReducedPerUse = 50;
            this.Damage = 100;
        }
    }
}