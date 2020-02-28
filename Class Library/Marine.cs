using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Marine : UnscTroop
    {
         public Marine(int hp, Weapon weapon)
        {
            this.Hp = hp;
            this.EquippedWeapon = weapon;
        }
    }
}