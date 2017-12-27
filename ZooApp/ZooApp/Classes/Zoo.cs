﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public class Zoo
    {
        public string Name { get; set; }
        public int NumberOfAnimals { get; set; }
        public bool SouvenirShop { get; set; }

        public void Explore()
        {
            Console.WriteLine("Let's explore the remaining earthquake shacks and learn about the history of the zoo!");
        }
        public string Observe()
        {
            return "Starring at the animals is so much fun!:)";
        }

        public void Pet()
        {
            Console.WriteLine("Every one likes to pet a cute animal.");
        }

        public void TakeARide()
        {
            Console.WriteLine("Take a ride on this little puffer train and get an up-close look at the grizzly bears foraging for food!");
        }
    }
}
