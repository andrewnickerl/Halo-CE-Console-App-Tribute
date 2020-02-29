using System;
using System.Collections.Generic;
using MilitaryClassLibrary;
using System.Threading;

namespace Military
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This console app will utilize the class library "MilitaryClassLibrary"
             * by way of tribute to Halo: Combat Evolved, allowing the user 
             * to run through a the storyline of the fourth campaign level of the
             * game.  In this application the user will execute an assault from human (UNSC)
             * forces led by Spartan John-117 (Master Chief) on an island on the Halo 
             * construct to locate what the Covenant refers to as "The Silent Cartographer".
             * The Cartographer is a map room for the Halo construct, which will allow John-117
             * to locate Halo's control center.  Although the objects from the class library
             * are utilized little in this program, I hope to use the class library as part of
             * side project over the next few weeks to create a simple non-console-based game
             * which relies on data and method from these classes and objects.
             */
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowWidth = 130;
            Console.WindowHeight = 50;
            
            var halo = new[] {
" .....                                        .                      ..                             .......''......               ",
",clld:              .                       .;:;'.                  .cl:'                       ...;cclllooodddddddolc;'.         ",
":oood:             'c;,'.                 .:lllcc:'                 .loll:.                  .,;;,''............',:cdO00Odc.      ",
";odxx;             'olccl,                ',..:odoo:.               .lolll:.               ,lc,.                     .:k00Okl.    ",
",cclo:.............:kkxdx:             ........:dxxxdc.             .ldlloc.               .,.          .,,,'.         .ldooxd,...",
",ccllcc:;;;;;:::cclokkkkk:           ,dOOOkdooooodxOOOkl.           .okddxo.                           .okkkx:.         ,lllol:','",
",cccccc'           .ccccl;         .lO0KKk:..    ..lO000kc.         .dOkO0d.                             ....         .,loddo,    ",
":lllccc'           .ccccl;       .:xkkOx:.          .cdxxxl'        .lxxxxd;..       .                            .';ldkOOd:.     ",
"cxxxxxx,           .oxddx:      ;dOOOkl.              'okOOko,       ,d00OOOkxdddddxxxxxxd:.      .colllcccccclodkO0K0kdc,.       ",
".''''''.            '''''.     .'''''.                 .',,,,'        .,,,,,,,,,,,,,,,,,,,,.       ...',cdxddddoolc:,..           "};

            var masterChief = new[]
            {
"MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM",
"MMWWWWWWWWWWWWWWWWWWWWWWWWWWNNNNNNNXKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKXNNNNNNWWWWWWWWWWWWWWWWWWWWWWWWWWWMMMM",
"MWXXXXXXXXXXXXXXXXXXXXXXXXXKo:::::;'........................................................;:::::lOXXXXXXXXXXXXXXXXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXXXXXXXXXXXXXXXX0l,,;,''.........................................................'',;;,:kXKXXXXXXXXXXXXXXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXXXXXXXXXXXKxccc:;;o0d..l000000000000000000x:ck00000000000Ol;o00000000000000000Kd..o0x:;:ccco0XXXXXXXXXXXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXXXXXXXXXXXKo,,,,''lKk'.dXXXXXXXXXXXXXXXXXXx;:OXXXXXXXXXXX0l,oKXXXXXXXXXXXXXXXXXx'.dXx,'',,,c0XXXXXXXXXXXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXXXXXXXklllc:;lkx'..':x0KXXXXXXXXXXXXXXXKxldO0KXXXXXXXXXXXX0Oxld0XXXXXXXXXXXXXXXK0kc'...oOo;:clllxKXXXXXXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXXXXXXXd,'''''cKO,   ,OXXXXXXXXXXXXXXXXNKl'lKXXXXXXXXXXXXXXXXd,:OXXXXXXXXXXXXXXXXX0;   .xXd''''''lKXXXXXXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXXXXXXXd;:dkkko;:dkkkOKXXXXXXXXXXXXXXX0dl:,oKXXXXXXXXXXXXXXXXx;:loOXXXXXXXXXXXXXXXXOkkkdc;lkkkxl,oKXXXXXXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXXXXXXXo':0XXXo..xXXXXXXXXXXXXXXXXXXXNk;''.lKXXXXXXXXXXXXXXXXd''''dXXXXXXXXXXXXXXXXXXXXO' cXXXKl.cKXXXXXXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXXXXKxodxkKKd:ldkKXXXXXXXXXXXXXXXXXXOdl;;lxOXXXXXXXXXXXXXXXXX0xo:,cdkKXXXXXXXXXXXXXXXXXKkdl:o0XOxxdd0XXXXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXXXX0:'oXXN0; ;KXXXXXXXXXXXXXXXXXXXXo'..,xXXXXXXXXXXXXXXXXXXXXXO:.'.c0XXXXXXXXXXXXXXXXXXXXc 'ONXXk,,kXXXXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXX0xo:,cdolclokXXXXXXXXXXXXXXXXXXKkdc,:ox0XXXXXXXXXXXXXXXXXXXXXKxoc,:dx0XXXXXXXXXXXXXXXXXXkoollodl;;ldOXXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXXx,..'...  oXXXXXXXXXXXXXXXXXXXXO:.''c0XXXXXXXXXXXXXXXXXXXXXXXXXXo''.,xXXXXXXXXXXXXXXXXXXXNx. ...''..lKXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXXx;;looo:..dXXXXXXXXXXXXXXXXXX0kd:,,,l0XXXXXXXXXXXXXXXXXXXXXXXXXKo,,,;oxOXXXXXXXXXXXXXXXXXXk'.:oool:,oKXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXXx,:ONXNx..oXXXXXXXXXXXXXXXXXXx,'''''c0XXXXXXXXXXXXXXXXXXXXXXXXXKo,'''''lKXXXXXXXXXXXXXXXXXx. oNXNKl'oKXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXXx;cOXkdc..:oooooooooooooooooo:......,ldooooooooooooooooooooooooo;......;odooooooooooooooooc..:dkXKl,dKXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXXx;:OK:                                                                                         ,0Kl,oKXXXXXXXXXXNMMMM",
"MWXXXXXXXXX0Oxlldx;..,;...;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;...,;..,dxocdO0KXXXXXXXXNMMMM",
"MWXXXXXXXXKo,oKk'   ,OK; :KXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXc ,OK;   .xXx;cOXXXXXXXXNWMMM",
"MWXXXXXXXXKo,oKOc'..;0K:.:KXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXl.;OK:..':kXx;cOXXXXXXXXNMMMM",
"MWXXXXXXXXKo;oKXXKc ,OK; :KXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXc.,OK: ;0XXXx;cOXXXXXXXXNMMMM",
"MWXXXXXXXXKo,oKXXKc.;0K:.:KXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXl.,OK:.:0XXXx;cOXXXXXXXXNMMMM",
"MWXXXXXXXXKo;oKXXKc.;0K: :0XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXl.,OK: :0XXXx:cOXXXXXXXXNMMMM",
"MWXXXXXXXXKl,l0KXKc.;0K:.:0KXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXK0l.;OK: :0XKKd;cOXXXXXXXXNMMMM",
"MWXXXXXXXXKo;,.;OXc..:lx0o';kXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXO:'l0koc'.:K0c.,;cOXXXXXXXXNMMMM",
"MWXXXXXXXXKl'. 'kKc..',xXo.'xXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXO,.lXO:'..:0O, .':OXXXXXXXXNMMMM",
"MWXXXXXX0doxkc..',lkOkOKXd.'kXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXO;.lXKOkkko;'..:kkookXXXXXXNMMMM",
"MWXXXXXXk;,xXl.   lXXXXXXo..xXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXNO' cXXXXXXd.   :X0:,dXXXXXXNMMMM",
"MWXXXXXXk:,;;cxo'.oXXXXXX0kdc;dXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXk::ox0XXXXXXd..lxl;;;;xXXXXXXNMMMM",
"MWXXXXXXk;.  ;Kk' lXXXXXXXXO' cXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXo .xXXXXXXXXo..xXc ..'dXXXXXXNMMMM",
"MWXXXXXXk:'..cKO,.oXXXXXXXXKkolco0XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXKd:lox0XXXXXXXXd.'kXl..';xXXXXXXNMMMM",
"MWXXXXXXk;.  ;KO. cXXXXXXXXXXXc 'ONXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXN0, ;KXXXXXXXXXXo..xXc  .'dXXXXXXNMMMM",
"MWXXXXXX0xo;';lllodxxxx0XXXXXXkolloOXXXXXXXXXXXXXXXXXX0xxxxxxxxxxxxxxxxxOXXXXXXXXXXXXXXXXXXOollokXXXXXXKkxxxdolll:';ldOXXXXXXNMMMM",
"MWXXXXXXXXKl'. .kXd'..,xXXXXXXXXx. lXXXXXXXXXXXXXXXXXXx,''''''''''''''''oKXXXXXXXXXXXXXXXXXd..dNXXXXXXXO;.'.cK0' .':OXXXXXXXXNMMMM",
"MWXXXXXXXXKxolcloooooooxkOXXXXXX0oldkxoooooooooooooooo:.................;looooooooooooooodkdllOXXXXXX0kxooolooolclod0XXXXXXXXNMMMM",
"MWXXXXXXXXXXXXNk. cXXXKl'l0XXXXXXXXo'.                                                   .'c0NXXXXXXXd,:0XXNo .xNXXXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXXXX0o:ldxOkl,lkOKXXXXXXxlc::::::::;'..;:::;''''''''''''''''',:::;...;::::::::cldKXXXXXK0Oo;cxOxdo:lOXXXXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXXXXXXX: .',,,,,:kXXXXXXXXXXXXXXXXXK: ,0XXXk;,,,,,,,,,,,,,,,,oXXXK: ;0NXXXXXXXXXXXXXXXX0c,,,,,'. ;0XXXXXXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXXXXXXXd;:c:,.',:x0000XXXXXXXXXXXXXKl.;dkKXklccccccccccccccccxXKOx:.c0XXXXXXXXXXXXXK000kc,,.,:c;,oKXXXXXXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXXXXXXXXXXX0; .,;,;;;cOXXXXXXXXXXXXKd;'..dXXXXXXXXXXXXXXXXXXXXXk. ';l0XXXXXXXXXXXXKo;;;;;,. ,OXXXXXXXXXXXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXXXXXXXXXXXKl',:;,',,cOKKXXXXKKKKKK0d:,..xXXXXXXXXXXXXXXXXXXXXXk'.,:o0KKKKKKXXXXXK0o;,'';:,'c0XXXXXXXXXXXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXXXXXXXXXXXXXKKKk, .;;;:xXXXKo::::::dKd..dXXXXXXXXXXXXXXXXXXXXXk'.lKkc:::::lOXXXOl:;;'.'xKKKXXXXXXXXXXXXXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXXXXXXXXXXXXXXXX0:.,;,',dKKX0o;;;;;;xXx..xXXXXXXXXXXXXXXXXXXXXXk'.oXOc;;;;;cOXKXk;',;'.;kXXXXXXXXXXXXXXXXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXXXXXXXXXXXXXXXXXK000d'.,ccclk000000KXx..xXXXXXXXXXXXXXXXXXXXXXk'.oXK000000Ooccc;..o000KXXXXXXXXXXXXXXXXXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXk,.',,';kXXXXXXXXx..xXXXXXXXXXXXXXXXXXXXXXk'.oXXXXXXXX0c'','..dXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXK0OOOo..xXXXXXXXXx..xXXXXXXXXXXXXXXXXXXXXXk'.oXXXXXXXXO,.cOOOOKXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXd..xXXXXXXXXd..dXXXXXXXXXXXXXXXXXXXXXk'.oXXXXXXXXk'.lXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX0kxc,,,,,,,,'..',:loooollllllllooll:,'..',,,,,,,,:dk0XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXNMMMM",
"MWXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXO,             ...................             .kXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXNWMMM",
"MMWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWN0kkkkkkkkkkkkkOOOOOOOOOOOOOOOOOOkkkkkkkkkkkkkk0NWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWMMMM",
"MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM" };

            foreach (var item in halo)
            {
                Thread.Sleep(250);
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in masterChief)
            {
                Thread.Sleep(50);
                Console.WriteLine(item);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Run();
        }

        static bool Run()
        {
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
            EnergySword energySword = new EnergySword();
            EnergyCannon energyCannon = new EnergyCannon();

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
            Elite elite1 = new Elite(plasmaRifle);
            Elite elite2 = new Elite(plasmaRifle);
            Elite elite3 = new Elite(plasmaRifle);
            Elite elite4 = new Elite(energySword);
            elite4.ActiveCamo = true;
            Grunt grunt1 = new Grunt(plasmaPistol);
            Grunt grunt2 = new Grunt(plasmaPistol);
            Jackal jackal1 = new Jackal(needler);
            Jackal jackal2 = new Jackal(needler);
            Hunter hunter1 = new Hunter(energyCannon);
            Hunter hunter2 = new Hunter(energyCannon);

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

            void OutputHeading()
            {
                Console.WriteLine($"Mission: {silentCartographer.Name}");
                Console.WriteLine("__________________________________________________________________________________________________________________________________\n");
                Console.WriteLine($"Objective: {silentCartographer.Objective}");
                Console.WriteLine("__________________________________________________________________________________________________________________________________\n");
                Console.WriteLine($"Weapon: {john117.EquippedWeapon.Name}");
                Console.WriteLine("__________________________________________________________________________________________________________________________________\n");
                if (john117.EquippedVehicle != null)
                {
                    Console.WriteLine($"Current Vehicle: {john117.EquippedVehicle.Name}");
                    Console.WriteLine("__________________________________________________________________________________________________________________________________\n");
                }
            }

            try
            {
                john117.EquipVehicle(pelican);
                OutputHeading();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();

                OutputHeading();
                Console.WriteLine("Cortana: \"The Covenant believe that what they call \"the Silent Cartographer\" is somewhere under this island.The Cartographer is a map room that will lead us to Halo's control center. The island has multiple structures and installations. One of them contains the map room.\"");
                Console.WriteLine("Carol Rawley (COM): \"We're approaching the LZ, it's gonna be hot! Get set to come out swingin'. Touchdown! Hit it, Marines!\"");
                Console.WriteLine("Staff Sergeant Stacker: \"Pile out people, let's move!\"");
                Console.WriteLine("\n\nPress any key to continue the mission...");
                john117.ExitVehicle();
                Console.ReadKey();
                Console.Clear();

                OutputHeading();
                Console.WriteLine("The LZ is filled with Covenant, incuding several Elites commanding a squad of Grunts apiece.\n");
                Console.WriteLine("Master Chief and his squad of Marines clear the LZ of Covenant hostiles.");
                Console.WriteLine("Cortana: \"Area's secure.\"");
                Console.WriteLine("Foehammer (COM): \"Affirmative. Echo 419 inbound. Somebody order a Warthog? \"");
                john117.EquipVehicle(warthog);
                Console.WriteLine("\nMaster Chief boards the driver seat of the Warthog, and two Marines occupy the passenger seat and the turret.\n");
                Console.WriteLine("Cortana: \"Okay, let's move out. Let's go find the map room that will show us the location of Halo's control center.\"");
                Console.WriteLine("\n\nPress any key to continue the mission...");
                Console.ReadKey();
                Console.Clear();

                OutputHeading();
                Console.WriteLine("The team approaches the main building.");
                Console.WriteLine("Cortana: \"There, in the cliff wall; I'll bet the Silent Cartographer is somewhere inside that facility.\"");
                Console.WriteLine("John: They're already inside! We need to get in there quick, before they discover the location of Halo's control center!");
                john117.ExitVehicle();
                Console.WriteLine("\n\nPress any key to continue the mission...");
                Console.ReadKey();
                Console.Clear();

                OutputHeading();
                Console.WriteLine("John shoots his way into the facility, fighting his way through a group of shield and needler-weilding Jackals, and more groups of Elites and Grunts.\n");
                Console.WriteLine("Cortana: \"The Covenant are putting up a real fight! The Cartographer must be here.My analysis indicates that the map room should be at the bottom floor of this facility.Let's keep going inside.\"");
                Console.WriteLine("John reaches the top of a slope that leads to an open door. A group of Covenant stand guard at the door, with a Zealot blocking the way in.");
                Console.WriteLine("Cortana: \"Don't let them lock the doors!\"");
                Console.WriteLine("\nThe doors close.\n");
                Console.WriteLine("Cortana: \"Interesting...I underestimated the Covenant's understanding of Halo's subsystems. They've locked the doors, and we don't have enough firepower to get through them.\"");
                Console.WriteLine("\n\nPress any key to continue the mission...");
                Console.ReadKey();
                Console.Clear();

                OutputHeading();
                Console.WriteLine("Cortana(COM): \"Cortana to Keyes.\"");
                Console.WriteLine("Captain Jacob Keyes (COM): \"Go ahead, Cortana.Have you found the control center? \"");
                Console.WriteLine("Cortana(COM): \"Negative, Captain. The Covenant have impeded our progress. We can't proceed unless we can disable this installation's security system.\"");
                Console.WriteLine("Captain Keyes (COM): (slight pause) \"Understood.We're still en route to the objective. I may be out of contact when we get there. (pause) Here are your orders. I want you to use any means necessary to force your way into the facility and find Halo's control center.We have to get to the center before the Covenant, and failure, people, is not an option.\"");
                Console.WriteLine("Foehammer(COM): \"Echo 419 to ground teams. I'll stay on station and keep an eye out for Covenant boogies.\"");
                Console.WriteLine("Staff Sergeant Stacker (COM): \"Second squad, ready to roll! Soon as everybody's topside!\"");
                Console.WriteLine("Marine (COM): \"LZ looks secure, Sir, nothing moving.\"");
                Console.WriteLine("Captain Keyes (COM): \"Good luck, people. Keyes out.\"");
                Console.WriteLine("Cortana: \"We need to find the security override to get this door open. It looks like there is a path leading to the interior of the island.\"");
                Console.WriteLine("\nJohn makes his way towards the security substation, fighting past multiple Covenant troops including a pair of Hunters.");
                Console.WriteLine("\nEventually, he reaches the substation. Once inside, fights through another pair of Hunters.");
                Console.WriteLine("\n\nPress any key to continue the mission...");
                Console.ReadKey();
                Console.Clear();

                OutputHeading();
                Console.WriteLine("Master Chief reaches the security override panel within the facility.");
                Console.WriteLine("Cortana: \"Use the holo panel to shut down the security system.\"");
                Console.WriteLine("\nJohn shuts down the security system and moves down the hall from the security substation, towards the exit.\n");
                Console.WriteLine("Bravo 022 Pilot (COM): \"Mayday, mayday! Dropship Bravo 022 taking enemy fire! Repeat! We are under heavy fire and are losing altitude!\"");
                Console.WriteLine("Cortana(COM): \"Understood.We're on our way.\"");
                Console.WriteLine("\nOn his way out of the subsystem John is attacked by a group of stealthed Elites with energy swords.  He fights through and defeats them, exiting the substation.");
                Console.WriteLine("\n\nPress any key to continue the mission...");
                Console.ReadKey();
                Console.Clear();

                OutputHeading();
                Console.WriteLine("John exits the substation and sees Bravo 022's wreckage on the beach below. Marine bodies and Covenant forces can be seen around it.\n");
                Console.WriteLine("Cortana: \"Chief, Bravo 022 was bringing us some heavy weapons. After I saw we were up against Hunters, I thought you could use them. Let's move down the beach. Keep an eye out for any cargo we can salvage.\"");
                john117.EquipWeapon(rl);
                Console.WriteLine("\nJohn salvages an overshield and some health packs from the wreckage, as well as equipping a rocket launcher from a fallen Marine.");
                Console.WriteLine("\n\nPress any key to continue the mission...");
                Console.ReadKey();
                Console.Clear();

                OutputHeading();
                Console.WriteLine("Master Chief travels back down through the island to the entrance of the Cartographer, which is now guarded by a pair of Hunters. He defeats the Mgalekgolo and enters the structure once more.");
                Console.WriteLine("\nJohn passes through the previously locked door and moves farther down into the facility.\n");
                Console.WriteLine("Foehammer (COM): \"Foehammer to ground teams, you got two enemy dropships coming in fast!\"");
                Console.WriteLine("Staff Sergeant Stacker (COM): \"Dammit! Okay, people, we got company comin', let's set the table. Engage enemy forces on sight!\"");
                Console.WriteLine("Cortana (COM): \"It'll be easier to hold them off from inside the structure. Can you get inside?\"");
                Console.WriteLine("Sergeant Stacker (COM): \"Negative! They're closin' in too fast, negative!(pause) Chief! You gotta find the Cartographer! We'll keep 'em busy as long as we can!\"");
                Console.WriteLine("Cortana (COM): \"Give 'em hell, Marine.\"");
                Console.WriteLine("\n\nPress any key to continue the mission...");
                Console.ReadKey();
                Console.Clear();

                OutputHeading();
                Console.WriteLine("Cortana: \"We'll be in a tight spot if we don't get out of here before additional reinforcements arrive.Let's find that map.\"");
                Console.WriteLine("\nJohn walks into the room containing the Silent Cartographer, which is a large holocron display.  He activates the holo-panel.\n");
                Console.WriteLine("The Silent Cartographer holo display begins to spin, and the diagram of Halo begins to break into sections.");
                Console.WriteLine("Cortana: \"Analyzing... Halo's control center is located there. That structure appears to be some sort of temple or shrine, if I've interpreted this correctly. (pause) Interesting. A shrine is an unlikely place to put such a significant installation.\"");
                Console.WriteLine("Cortana (COM): \"Cortana to Captain Keyes.\"");
                Console.WriteLine("Foehammer (COM): \"The Captain has dropped out of contact, Cortana.His ship may be out of range or having equipment problems.\"");
                Console.WriteLine("Cortana (COM): \"Keep trying.Let me know when you've reestablished contact, and then tell him that John-117 and I have determined the location of the control center. We'll be heading there as soon as we're topside.\"");
                Console.WriteLine("Foehammer (COM): \"Affirmative.Foehammer out.\"");
                Console.WriteLine("\n\nPress any key to continue the mission...");
                Console.ReadKey();
                Console.Clear();

                OutputHeading();
                Console.WriteLine("Covenant reinforcements have retaken the upper levels of the facility, forcing John to fight his way back up.\n");
                Console.WriteLine("Cortana (COM): \"Cortana to Echo 419.The Chief and I are topside, requesting pickup.\"");
                Console.WriteLine("Foehammer (COM): \"Roger.On my way.\"");
                Console.WriteLine("\nThe pelican arrives and Joh boards.");
                john117.EquipVehicle(pelican);
                Console.WriteLine("\n\nPress any key to continue the mission...");
                Console.ReadKey();
                Console.Clear();

                OutputHeading();
                Console.WriteLine("Echo 419 lifts off from the platform and rises quickly, circling the center of the island.");
                Console.WriteLine("Cortana (COM): \"Let's get moving. Foehammer. Here are coordinates and a flight plan I've worked out.\"");
                Console.WriteLine("Foehammer (COM): \"But, Cortana... these coordinates are underground.\"");
                Console.WriteLine("Cortana (COM): \"The Covenant did a thorough seismic scan.My analysis shows that Halo is honeycombed with deep tunnels - which circle the whole ring.\"");
                Console.WriteLine("\nA structure lifts up from the island, revealing an underground tunnel; Echo 419 lowers into it.");
                Console.WriteLine("Foehammer (COM): \"I hope your analysis is on - the - money, Cortana.This Pelican won't turn on a dime.\"");
                Console.WriteLine("Cortana (COM): \"Look on the bright side, Foehammer.The last thing the Covenant will expect is an aerial insertion... from underground.\"");
                Console.WriteLine("\n\nPress any key to end the mission...");
                Console.ReadKey();
                Console.Clear();

                var halo = new[]
                {
"                                            ...................................                                                   ",
"                                      ...''''',,,,,,,,,,',,,,,,,,,,,,,,,,,,,,,'''''.....                                          ",
"                                    .'',,''',,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,''....                                    ",
"                               ...''',,,''',,,'',,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,''....                              ",
"                          ....',,,,'',,,,,,''''''.....................'''''',,,,,,'',,,,,,,,,',,,,,''..                           ",
"                      ...'',,',,,,,'''.......                              .......'',,,,,',,,,,,,,,,,,,'..                        ",
"                   ..'',,,',,''.....        .................  ....  ....    ..........''',,',,,',,,,',,,''..                     ",
"                 .'',,,,,''...             .'.'',;,,;;c;,;''. .;,..'','';'.',';;,,,.     ..'',,,,,,,,,,,',,''.                    ",
"               .'',,,,,'..                                                                  ..'',,,,;;;;;;;,,,'.                  ",
"      ,llol'..',,',,''..                       ,c:.                 .cc,.                     .;odxxkkkkkkkkxxdoc'.               ",
"     .lO00Ol'',,,,,'.  .:l:,.                'oO0Ox:.               ,k0Od'                ..;coxxdxddddddddxxkOOOOxo:.            ",
"    .,okkkkl,',,,'.    .okkko'              ,cclxkkko,.             'dkkkd'             .;ooc;... .',,,,,,,,,;:codkkkxc.          ",
"    .,lddddl:::;;,.....,odddd;            ......;oddddc.            'odddd,             .;,.       .;:cc:;,,','',;cddddo;'''..    ",
"     .;lllllllcccccccccclllll,         .':lcccc:ccclllll;.          .cllll'                        'clolol;,,',,'';llllollc:,.    ",
"      ,ccccc:'.... .....;cccc'        .;ccc:,..    .':ccc:'.        .:ccc:'                        ';;::;;,'',,,,;:cccc:,''...    ",
"      ';;;;;,.         .,;;;;'      .';;;;'.         ..,;;;,.       .,;;;;,.............        ...,,,,,,,,,,,;;;;;;;'.           ",
"      .,,,,,'.          ',,,,.     .',,''.             ..',,,'.      .',,,,,,,,,,,,,,,,'.      .,;;;;;;;;;;;;;;;;,'.              ",
"                                                                                              ..',,,,,,,,,,,,,,,'.                ",
"                                                                                          ...',,,,,,,,,,,'',,,'.                  ",
"                                   .::.   ...   ...  ..        ...        ..   ..    ...''',;,,,,,,,,,,,,',,'.                    ",
"                                  .oooo..c:'c;.:c'::.;:.:,.;,'ccccl,,l;.,clc'.,lod:,oocldl:ol,,,,,,,,,,,,'..                      ",
"                                 .cl:cxo:d:.co,lc.,l,:c..ld:.,dl:cc,;l' 'codlcdxdOdcxl',cxOo;,,,',,,,,'...                        ",
"                                  ...,;:;:;';:,;;',;,;;'.;:,..;:cc:;,;,';:cc;;:ccc;;:;,';oo;,,,,',''...                           ",
"                                    ..'''',,,,,,,,,,,,,,,,,,',,,,,,,,,,,,,',,',,,,,,,,,,,,,,,''....                               ",
"                                         .........'',,',,,,,,',,,',,,,,,'',,,,,,,,,,''''.....                                     ",
"                                                    ..'',,'''''''''''...............                                              ",
"                                                       ...                                                                        "
                };

                foreach (var item in halo)
                {
                    Thread.Sleep(250);
                    Console.WriteLine(item);
                }

                Console.WriteLine("Thank you for participating in the runthrough of \"The Silent Cartographer\" from Halo: Combat Evolved!");

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
