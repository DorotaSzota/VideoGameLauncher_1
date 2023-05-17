using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame1
{
    internal class Warrior : Character,IPlayable
    {
        public int Health { get; private set; }
        public int Mana { get; private set; }
        public int Strength { get; private set; }
        public int Intelligence { get; private set; }

        public Warrior(string name) : base (name)
        {
            Health = 100;
            Mana = 20;
            Strength = 70;
            Intelligence = 20;
        }

        public void Play()
        {
            Console.WriteLine("You're now playing a warrior.");
        }


    }
}
