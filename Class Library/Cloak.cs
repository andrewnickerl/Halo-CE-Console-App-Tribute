using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Cloak : Equipment
    {
        public Cloak()
        {
            this.Description = "Grants a troop active camoflage.";
        }

        public override bool Action(Troop troop)
        {
            try
            {
                troop.ActiveCamo = true;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}