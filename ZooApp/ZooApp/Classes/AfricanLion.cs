using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public class AfricanLion : Safari
    {
        private TimeSpan _visitTime;
        public TimeSpan VisitTime
        {
            get { return base.TimeVisited(); }
            set { this._visitTime = value; }
        }

        public void LearnAboutLionsWhenResting()
        {
            Console.WriteLine("Calm and fearless are two of the Lion's qualities.");
        }

        public string TestingOutUnderlyingProperty()
        {
            return "Visit time is: " + _visitTime;
        }

        public bool IsFriendsWithRhino()
        {
            return false;
        }
    }
}
