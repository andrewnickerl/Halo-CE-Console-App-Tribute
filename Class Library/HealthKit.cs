using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class HealthKit : Equipment
    {
        public HealthKit()
        {
            this.Description = "Heals for 150 HP.";
        }

        public override bool Action(Troop unit)
        {
            try
            {
                //heals a troop either for 150 points or to their max HP if they are less than 150 HP away from it
                if (unit.CurrentHp < (unit.MaxHp - 150)) unit.CurrentHp += 150;
                else unit.CurrentHp = unit.MaxHp;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}