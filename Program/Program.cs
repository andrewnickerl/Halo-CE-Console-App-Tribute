using System;
using System.Collections.Generic;
using MilitaryClassLibrary;

namespace Military
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This program will utilize the class library "MilitaryClassLibrary"
             * in order to provide a tribute to Halo: Combat Evolved, allowing the user 
             * to run through a console app version of the fourth campaign level of the
             * game.  In this application the user will execute an assault from human (UNSC)
             * forces led by Spartan John-117 (Master Chief) on an island on the Halo 
             * construct to locate what the Covenant refers to as "The Silent Cartographer".
             * The Cartographer is a map room for the Halo construct, which will allow John-117
             * to locate Halo's control center.
             */

            //UNSC Weapons
            Magnum magnum = new Magnum();
            AssaultRifle ar = new AssaultRifle();
            RocketLauncher rl = new RocketLauncher();
            Grenade grenade = new Grenade();

            //Covenant Weapons
            PlasmaPistol plasmaPistol = new PlasmaPistol();
            PlasmaRifle plasmaRifle = new PlasmaRifle();
            Needler needler = new Needler();
            PlasmaGrenade plasmaGrenade = new PlasmaGrenade();

            //UNSC Troops
            Spartan john117 = new Spartan(ar);
            Marine marine1 = new Marine(ar);
            Marine marine2 = new Marine(ar);
            Marine marine3 = new Marine(magnum);
            Marine marine4 = new Marine(rl);
            Marine marine5 = new Marine(magnum);
            Marine marine6 = new Marine(ar);
            Marine marine7 = new Marine(rl);
            Marine marine8 = new Marine(magnum);
            Marine marine9 = new Marine(ar);

            //UNSC Vehicles
            Pelican pelican = new Pelican();
            Warthog warthog = new Warthog();

            //Covenant Troops
            Elite elite1 = new Elite();
            Elite elite2 = new Elite();
            Elite elite3 = new Elite();
            Elite elite4 = new Elite();
            Grunt grunt1 = new Grunt();
            Grunt grunt2 = new Grunt();
            Jackal jackal1 = new Jackal();
            Jackal jackal2 = new Jackal();
            Hunter hunter1 = new Hunter();
            Hunter hunter2 = new Hunter();



            //Covenant Vehicles
            Spirit spirit = new Spirit();

            //Equipment
            HealthKit hk = new HealthKit();
            Overshield os = new Overshield();
            Cloak activeCamo = new Cloak();

            //Objective
            Mission silentCartographer = new Mission();
            silentCartographer.Name = "The Silent Cartographer";
            silentCartographer.Objective = "Execute a USNC assault led by Spartan John-117 " +
                "(Master Chief) on an island on the Halo construct to locate what the Covenant " +
                "refers to as\"The Silent Cartographer\".  The Cartographer is a map room for " +
                "the Halo construct. Accessing it will allow John-117 to locate Halo's control center.";

            Run();

        }

        static bool Run()
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
