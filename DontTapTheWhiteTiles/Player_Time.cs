using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontTapTheWhiteTiles
{
    public class Player_Time: Player,IComparable<Player_Time>
    {
        public int tiles { get; set; }

        public Player_Time(string Name,string Surname,int tiles) : base(Name,Surname)
        {
            this.tiles = tiles;
        }

        public int CompareTo(Player_Time other)
        {
            return other.tiles.CompareTo(tiles);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Name, Surname, tiles);
        }
    }
}
