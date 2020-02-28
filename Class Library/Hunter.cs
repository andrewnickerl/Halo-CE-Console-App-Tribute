using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Hunter : Covenant
    {
        public Hunter(Weapon weapon)
        {
            this.CurrentHp = 300;
            this.MaxHp = 300;
            this.EquippedWeapon = weapon;
        }
    }
}