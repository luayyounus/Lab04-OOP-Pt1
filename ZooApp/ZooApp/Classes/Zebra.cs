using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public class Zebra : AfricanLion
    {
        public string SpeciesName { get; set; }
        public bool Stripes { get; set; }
        public float Weight { get; set; }

        public void KeepCool()
        {
            Console.WriteLine("Isn't that what Zebras do all the time?");
        }

        public int CheckMinimumDangerLevel()
        {
            Console.WriteLine("This method inside Zebra class is inherting Danger level from Safari Class");
            return DangerLevel;
        }
    }
}
