using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Jackal : Covenant
    {
        public Jackal(Weapon weapon)
        {
            this.CurrentHp = 75;
            this.MaxHp = 75;
            this.EquippedWeapon = weapon;
        }
    }
}