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
