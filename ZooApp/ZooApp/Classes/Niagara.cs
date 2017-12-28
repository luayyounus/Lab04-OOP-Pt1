using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public class Niagara : Safari
    {
        public string ParkInfo { get; set; }
        public int NumberOfRestaurants { get; set; }
        public bool LockersAvailability { get; set; }

        public override void Explore()
        {
            Console.WriteLine("Overriding again down from the Zoo base class.");
            base.Explore();
        }

        public void DemonstratePreyFlying()
        {
            Console.WriteLine("Birds soaring high... found a prey! Swooosh, yummm :)");
        }

        public void VisitBBQMarket()
        {
            Console.WriteLine("Fruits and BBQ are main facilities in {0}", this.ParkInfo);
        }
    }
}
