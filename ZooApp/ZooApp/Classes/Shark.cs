using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    class Shark : SouthPacific
    {
        private int speed;
        public bool Friendly { get; set; }
        public string Species { get; set; }

        public int Speed
        {
            get { return this.speed; }
            set { this.speed = base.Speed; }
        }

        public void FindSharks()
        {
            Console.WriteLine("Sharks are scary and finding them is scarier.");
        }
    }
}
