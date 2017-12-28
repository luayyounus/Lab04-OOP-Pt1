using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public class SouthPacific : Aquaria
    {
        public string World { get; set; }
        public int Speed { get; set; }
        public string[] Colors { get; set; }
        public float Length { get; set; }

        public bool CanNemoSwim(int speed)
        {
            if (this.Speed % speed == 0)
            {
                Console.WriteLine("Nemo can swim at this current speed!!!");
                return true;
            }
            return false;
        }

        public string NumberOfRareAnimal(string fish)
        {
            return this.Colors[base.NumberOfRareAnimals];
        }
    }
}
