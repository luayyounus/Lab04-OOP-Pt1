using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public class Turtle : SouthPacific
    {
        public bool Amphibious { get; set; }
        public string Shield { get; set; }
        public string Color { get; set; }

        public string BelongsTo()
        {
            return World;
        }

        public bool AvailableInShop()
        {
            return base.SouvenirShop;
        }
    }
}
