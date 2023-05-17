using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame1
{
    internal class Character: IEnumerable<Character>
    {
        public string Name { get; set; }

        public Character(string name)
        {
            Name = name;
        }
        IEnumerator<Character> IEnumerable<Character>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
       
    }
}
