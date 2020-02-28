using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Elite : Covenant
    {
        public Elite(int hp, Weapon weapon)
        {
            this.Hp = hp;
            this.EquippedWeapon = weapon;
        }
    }
}