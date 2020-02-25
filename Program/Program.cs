using System;
using MilitaryClassLibrary;

namespace Military
{
    class Program
    {
        static void Main(string[] args)
        {
            Spartan john117 = new Spartan();
            AssaultRifle ar = new AssaultRifle();
            john117.EquipWeapon(ar);

            Jackal jackal = new Jackal();
            PlasmaPistol plasmaPistol = new PlasmaPistol();
            CovenantWeapon shield = new CovenantWeapon();            
            jackal.EquipWeapon(shield, plasmaPistol);
            Console.WriteLine(jackal.EquippedWeapon);

            Troop troop = jackal;

            
        }
    }
}
