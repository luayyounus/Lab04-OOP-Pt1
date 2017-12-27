using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public class Lion : AfricanLion
    {
        public int AngerLevel { get; set; }
        public bool IsKing { get; set; }
        public bool HasChildren { get; set; }

        public void LookForAPrey()
        {
            Console.WriteLine("Finding my food is my easiest job ;)");
        }

        public void Roar()
        {
            Console.WriteLine("I am the king and I scare all animals! Though, I have a very sweet heart.");
        }
    }
}
