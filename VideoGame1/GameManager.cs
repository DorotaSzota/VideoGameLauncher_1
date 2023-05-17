using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame1
{
     internal class GameManager<Character> : IPlayable
    {

        public void StartGame(Character character) 
        {
            Console.WriteLine("Launching the game...");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Current character: {0}.", character.GetType().Name);
        }


    }
}
