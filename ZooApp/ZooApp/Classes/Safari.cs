using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public abstract class Safari : Zoo
    {
        public override void Explore()
        {
            Console.WriteLine("I am overriding Zoo's abstract method! woot woot!");
        }

        public string Theme { get; set; }

        public bool Desert { get; set; }

        public int DangerLevel
        {
            get { return 10; }
            set { value = 10; }
        }

        public void WatchAnimals()
        {
            Console.WriteLine("Safaris are awesome beause we get to see wild animals!");
        }

        public TimeSpan TimeVisited()
        {
            return DateTime.Now.TimeOfDay;
        }

        public string LearnAnimalTribe()
        {
            return "";
        }
    }
}
