using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class SniperRifle : HumanWeapon
    {
        public SniperRifle()
        {
            this.Accuracy = 90;
            this.Ammo = 20;
            this.Damage = 75;
        }
    }
}