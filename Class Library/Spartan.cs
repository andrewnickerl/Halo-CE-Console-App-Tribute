using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Spartan : UnscTroop
    {
        public Spartan(Weapon weapon)
        {
            this.CurrentHp = 500;
            this.MaxHp = 500;
            this.EquippedWeapon = weapon;
        }
    }
}