using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class CovenantWeapon : Weapon
    {
        public int Battery { get; set; } = 100;
        public int BatteryReducedPerUse { get; set; } = 1;

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
                     *damage to troop fired upon and deplete battery appropriately */
                    if (num < this.Accuracy)
                    {
                        troop.CurrentHp -= this.Damage;
                        this.Battery = Battery - BatteryReducedPerUse;
                        this.Accuracy *= 2; //resets accuracy
                    }
                }
                //if no active camo
                else
                {
                    if (num < this.Accuracy)
                    {
                        troop.CurrentHp -= this.Damage;
                        this.Battery = Battery - BatteryReducedPerUse;
                    }
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