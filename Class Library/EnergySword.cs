using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class EnergySword : CovenantWeapon
    {
        public EnergySword()
        {
            this.Accuracy = 100;
            this.BatteryReducedPerUse = 20;
            this.Damage = 100;
        }
    }
}