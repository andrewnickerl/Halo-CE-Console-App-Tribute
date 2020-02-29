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
                Console.WriteLine("Cortana: \"The Covenant believe that what they call \"the Silent Cartographer\" is somewhere under this island.The Cartographer is a map room that will lead us to Halo\'s control center. The island has multiple structures and installations. One of them contains the map room.\"");
                Console.WriteLine("Carol Rawley (COM): \"We're approaching the LZ, it\'s gonna be hot! Get set to come out swingin\'. Touchdown! Hit it, Marines!\"");
                Console.WriteLine("Staff Sergeant Stacker: \"Pile out people, let's move!\"");
                Console.WriteLine("\n\nPress any key to continue the mission...");
                john117.ExitVehicle();
                Console.ReadKey();
                Console.Clear();

                OutputHeading();
                Console.WriteLine("The LZ is filled with Covenant, incuding several elites commanding a squad of grunts apiece.");
                Console.WriteLine("Master Chief and his squad of Marines clear the LZ of Covenant hostiles.");
                Console.WriteLine("Cortana: \"Area's secure.\"");
                Console.WriteLine("Foehammer (COM): \"Affirmative. Echo 419 inbound. Somebody order a Warthog ? \"");
                john117.EquipVehicle(warthog);
                Console.WriteLine("Master Chief boards the driver seat of the Warthog, and two Marines occupy the passenger seat and the turret.");
                Console.WriteLine("Cortana: \"Okay, let\'s move out. Let\'s go find the map room that will show us the location of Halo\'s control center.\"");
                Console.WriteLine("\n\nPress any key to continue the mission...");
                Console.ReadKey();
                Console.Clear();

                OutputHeading();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
