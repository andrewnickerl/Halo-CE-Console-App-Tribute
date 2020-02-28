using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Marine : UnscTroop
    {
         public Marine(Weapon weapon)
        {
            this.CurrentHp = 100;
            this.MaxHp = 100;
            this.EquippedWeapon = weapon;
        }
    }
}