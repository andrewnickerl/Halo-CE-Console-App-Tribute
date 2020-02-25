using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Jackal : Covenant
    {
        public new (Weapon, Weapon) EquippedWeapon { get; set; }

        public int Block(int incomingDamage)
        {
            int damageBlocked = incomingDamage;
            return damageBlocked;
        }

        public bool EquipWeapon(Weapon shield, Weapon weapon)
        {
            try
            {
                this.EquippedWeapon = (shield, weapon);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}