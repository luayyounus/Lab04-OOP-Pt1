using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    class AfricanLion : Safari
    {
        private TimeSpan visitTime;
        public TimeSpan VisitTime
        {
            get { return base.TimeVisited(); }
            set { this.visitTime = value; }
        }

        public void LearnAboutLionsWhenResting()
        {
            Console.WriteLine("Calm and fearless are two of the Lion's qualities.");
        }

        public bool IsThatAnAfricanLionRhino()
        {
            return false;
        }
    }
}
