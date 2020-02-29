using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class AssaultRifle : HumanWeapon
    {
        public AssaultRifle()
        {
            this.Accuracy = 75;
            this.Ammo = 300;
            this.Damage = 10;
        }
    }
}