using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Overshield : Equipment
    {
        public Overshield()
        {
            this.Description = "Gives a troop a shield of 150 HP beyond their current HP";
        }

        public override bool Action(Troop troop)
        {
            try
            {
                troop.CurrentHp += 150;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}