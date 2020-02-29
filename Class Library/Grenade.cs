using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Grenade : HumanWeapon
    {
        public Grenade()
        {
            this.Accuracy = 100;
            this.Ammo = 2;
            this.Damage = 100;
        }
    }
}