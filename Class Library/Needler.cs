using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Needler : CovenantWeapon
    {
        public Needler()
        {
            this.Accuracy = 65;
            this.BatteryReducedPerUse = 4;
            this.Damage = 50;
        }
    }
}