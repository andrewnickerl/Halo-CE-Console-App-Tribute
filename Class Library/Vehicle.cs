using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Vehicle
    {
        public string Name { get; set; }
        public int NumPassengers { get; set; }
        public Weapon Weapon { get; set; }
        public string Movement { get; set; }
    }
}