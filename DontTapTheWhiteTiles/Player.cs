using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DontTapTheWhiteTiles
{
    abstract public class Player
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Player(string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
        }

        abstract public override string ToString();
       
    }
}
