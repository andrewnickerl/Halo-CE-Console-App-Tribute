using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryClassLibrary
{
    public class Mission
    {        
        public List<string> Waypoints { get; set; }
        public string EndObjective { get; set; }
        public bool Accomplished { get; set; }
    }
}