using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Grunt : Covenant
    {
        public Grunt(Weapon weapon)
        {
            this.CurrentHp = 50;
            this.MaxHp = 50;
            this.EquippedWeapon = weapon;
        }
    }
}