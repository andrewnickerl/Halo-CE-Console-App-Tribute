using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Shotgun : HumanWeapon
    {
        public Shotgun()
        {
            this.Accuracy = 60;
            this.Ammo = 30;
            this.Damage = 100;
        }
    }
}