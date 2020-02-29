using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Cannon : HumanWeapon
    {
        public Cannon()
        {
            this.Accuracy = 80;
            this.Damage = 200;
        }

        /*cannon is a vehicle mounted weapon with unlimited ammo,
        * so we override the method from HumanWeapon to remove
        * the ammo manipulation aspects of the method.*/
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
                     *damage to troop fired upon */
                    if (num < this.Accuracy)
                    {
                        troop.CurrentHp -= this.Damage;
                        this.Accuracy *= 2; //resets accuracy
                    }
                }
                //if no active camo
                else
                {
                    if (num < this.Accuracy)
                    {
                        troop.CurrentHp -= this.Damage;
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