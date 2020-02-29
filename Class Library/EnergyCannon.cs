using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class EnergyCannon : CovenantWeapon
    {
        public EnergyCannon()
        {
            this.Accuracy = 85;
            this.BatteryReducedPerUse = 10;
            this.Damage = 150;
        }
    }
}