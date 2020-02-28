using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Grunt : Covenant
    {
        public Grunt(int hp, Weapon weapon)
        {
            this.Hp = hp;
            this.EquippedWeapon = weapon;
        }
    }
}