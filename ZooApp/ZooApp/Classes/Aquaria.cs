using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public class Aquaria : Zoo
    {
        public string BuildingSize { get; set; }
        public bool OpenOnTheWeekends { get; set; }
        public int NumberOfRareAnimals { get; set; }

        public void TakeAShortTour()
        {
            Console.WriteLine("Spend a few minutes looking for the smalles fish in the world.");
        }

        public string WatchSeaAnimals()
        {
            return Observe();
        }

        public override void Explore()
        {
            Console.WriteLine("I Explore Aquariums by overriding stuff.");
        }
    }
}
