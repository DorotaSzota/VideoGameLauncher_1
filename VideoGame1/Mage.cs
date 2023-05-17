using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame1
{
    internal class Mage : Character, IPlayable
    {
        public int Health { get; private set; }
        public int Mana { get; private set; }
        public int Strength { get; private set; }
        public int Intelligence { get; private set; }

        public Mage(string name) : base(name)
        {
            Health = 60;
            Mana = 100;
            Strength = 20;
            Intelligence = 70;
        }

        public void Play()
        {
            Console.WriteLine("You're now playing a mage.");
        }

        public void HandleEvent()
        { Console.WriteLine("The event is being handled."); }
    }
}
