using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    class Reptilia : Niagara
    {
        public bool AnimalExistance { get; set; }
        public int NumberOfGame { get; set; }

        public void DoActivity()
        {
            base.TakeARide();
        }

        public bool IsAThing()
        {
            Console.WriteLine("I don't know why Reptilia is a thing!");
            return false;
        }
    }
}
