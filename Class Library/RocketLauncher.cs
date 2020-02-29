using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class RocketLauncher : HumanWeapon
    {
        public RocketLauncher()
        {
            this.Accuracy = 90;
            this.Ammo = 6;
            this.Damage = 200;
        }
    }
}