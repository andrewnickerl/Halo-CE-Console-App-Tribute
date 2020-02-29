using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class AssaultRifle : HumanWeapon
    {
        public AssaultRifle()
        {
            this.Name = "Assault Rifle";
            this.Accuracy = 75;
            this.Ammo = 80;
            this.Damage = 20;
        }
    }
}