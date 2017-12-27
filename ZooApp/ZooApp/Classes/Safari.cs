using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    abstract class Safari : Zoo
    {
        public string Theme { get; set; }

        public bool Desert { get; set; }

        public int DangerLevel { get; set; }

        public void WatchAnimals()
        {
            Console.WriteLine("Safaris are awesome beause we get to see wild animals!");
        }

        public TimeSpan TimeVisited()
        {
            return DateTime.Now.TimeOfDay;
        }

        public bool LearnBehavior()
        {
            return true;
        }
    }
}
