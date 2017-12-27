﻿using System;
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

        public void MatchWithNemo(int speed)
        {
            if (speed == this.Speed)
            {
                Console.WriteLine("Match!!!");
            }
        }

        public string NumberOfRareAnimal(string fish)
        {
            return this.Colors[base.NumberOfRareAnimals];
        }
    }
}
