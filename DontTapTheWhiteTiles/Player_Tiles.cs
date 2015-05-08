using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontTapTheWhiteTiles
{
    public class Player_Tiles: Player,IComparable<Player_Tiles>
    {
        public int seconds { get; set; }

        public Player_Tiles(string Name,string Surname,int seconds) : base(Name,Surname)
        {
            this.seconds = seconds;
        }

        public int CompareTo(Player_Tiles other)
        {
            return seconds.CompareTo(other.seconds);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}:{3:00}",Name,Surname,seconds/60,seconds%60);
        }
    }
}
