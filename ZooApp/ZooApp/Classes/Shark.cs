using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    class Shark : SouthPacific
    {
        public int Speed;
        public bool Friendly { get; set; }
        public string Species { get; set; }

        public void FindSharks()
        {
            Console.WriteLine("Sharks are scary and finding them is scarier.");
        }

        public void Speak()
        {
            Console.WriteLine("Sharks like talking!");
        }

        public bool EatHumans()
        {
            return true;
        }
    }
}
