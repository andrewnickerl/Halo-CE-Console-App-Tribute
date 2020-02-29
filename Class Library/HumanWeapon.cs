using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class HumanWeapon : Weapon
    {
        public int Ammo { get; set; }

        public override bool Fire(Troop troop)
        {
            Random random = new Random();
            int num = random.Next(0, 100);

            try
            {
                // temporarily reduces accuracy by half if troop fired upon has active camo
                if (!!troop.ActiveCamo)
                {
                    this.Accuracy /= 2;
                    /*if weapon accuracy is higher than RNG num (1-100), deal weapon
                     *damage to troop fired upon and deplete ammo appropriately */
                    if (num < this.Accuracy)
                    {
                        troop.CurrentHp -= this.Damage;
                    }
                    this.Ammo--;
                    this.Accuracy *= 2; //resets accuracy
                } 
                //if no active camo
                else
                {
                    if (num < this.Accuracy)
                    {
                        troop.CurrentHp -= this.Damage;
                    }
                    this.Ammo--;
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}