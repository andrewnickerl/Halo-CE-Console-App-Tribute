using System;

namespace MilitaryClassLibrary
{
    public class Troop
    {
        public virtual Weapon EquippedWeapon { get; set; }
        public int CurrentHp { get; set; }
        public int MaxHp { get; set; }
        public bool ActiveCamo { get; set; } = false;

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
