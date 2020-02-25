using System;

namespace MilitaryClassLibrary
{
    public class Troop
    {
        public virtual Weapon EquippedWeapon { get; set; }

        public virtual bool EquipWeapon(Weapon weapon)
        {
            try
            {
                this.EquippedWeapon = weapon;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
