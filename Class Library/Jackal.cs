using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Jackal : Covenant
    {
        public Jackal(int hp, Weapon weapon)
        {
            this.Hp = hp;
            this.EquippedWeapon = weapon;
        }
    }
}