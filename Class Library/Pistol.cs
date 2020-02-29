using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Magnum : HumanWeapon
    {
        public Magnum()
        {
            this.Accuracy = 90;
            this.Ammo = 100;
            this.Damage = 10;
        }
    }
}