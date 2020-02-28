using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Spartan : UnscTroop
    {
        public Spartan(int hp, Weapon weapon)
        {
            this.Hp = hp;
            this.EquippedWeapon = weapon;
        }
    }
}