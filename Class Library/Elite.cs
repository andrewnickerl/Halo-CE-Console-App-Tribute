using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Elite : Covenant
    {
        public Elite(Weapon weapon)
        {
            this.CurrentHp = 200;
            this.MaxHp = 200;
            this.EquippedWeapon = weapon;
        }
    }
}