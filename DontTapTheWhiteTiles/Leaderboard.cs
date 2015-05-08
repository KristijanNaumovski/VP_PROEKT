using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontTapTheWhiteTiles
{
    public class Leaderboard
    {
        public List<Player_Time> ListFor1MinGame { get; set; }
        public List<Player_Time> ListFor30SecGame { get; set; }
        public List<Player_Tiles> ListFor100Tiles { get; set; }
        public List<Player_Tiles> ListFor300Tiles { get; set; }

        public Leaderboard()
        {
            ListFor100Tiles = new List<Player_Tiles>();
            ListFor300Tiles = new List<Player_Tiles>();
            ListFor1MinGame = new List<Player_Time>();
            ListFor30SecGame = new List<Player_Time>();
            loadResults();
        }

        public void checkScoreFor1MinGame(Player_Time player)
        {
            if (ListFor1MinGame.Count < 10)
            {
                ListFor1MinGame.Add(player);
            }
            else
            {
                Player_Time p = ListFor1MinGame[9] as Player_Time;
                if (player.tiles > p.tiles)
                {
                    ListFor1MinGame.RemoveAt(9);
                    ListFor1MinGame.Add(player);
                }
            }

            ListFor1MinGame.Sort();
            writeResults("scoresFor1MinGame.txt");
        }

        public void checkScoreFor30SecGame(Player_Time player)
        {
            if (ListFor30SecGame.Count < 10)
            {
                ListFor30SecGame.Add(player);
            }
            else
            {
                Player_Time p = ListFor30SecGame[9] as Player_Time;
                if (player.tiles > p.tiles)
                {
                    ListFor30SecGame.RemoveAt(9);
                    ListFor30SecGame.Add(player);
                }
            }

            ListFor30SecGame.Sort();
            writeResults("scoresFor30SecGame.txt");
        }

        public void checkScoreFor100TilesGame(Player_Tiles player)
        {
            if (ListFor100Tiles.Count < 10)
            {
                ListFor100Tiles.Add(player);
            }
            else
            {
                Player_Tiles p = ListFor100Tiles[9] as Player_Tiles;
                if (player.seconds < p.seconds)
                {
                    ListFor100Tiles.RemoveAt(9);
                    ListFor100Tiles.Add(player);
                }
            }

            ListFor100Tiles.Sort();
            writeResults("scoresFor100TilesGame.txt");
        }

        public void checkScoreFor300TilesGame(Player_Tiles player)
        {
            if (ListFor300Tiles.Count < 10)
            {
                ListFor300Tiles.Add(player);
            }
            else
            {
                Player_Tiles p = ListFor300Tiles[9] as Player_Tiles;
                if (player.seconds < p.seconds)
                {
                    ListFor300Tiles.RemoveAt(9);
                    ListFor300Tiles.Add(player);
                }
            }

            ListFor100Tiles.Sort();
            writeResults("scoresFor300TilesGame.txt");
        }

        private void writeResults(string name)
        {
            
            using (StreamWriter writer = new StreamWriter(name))
            {
                int i = 1;

                if (name == "scoresFor30SecGame.txt")
                {
                    foreach (Player p in ListFor30SecGame)
                    {
                        writer.WriteLine(i + ". " + p);
                        i++;
                    }
                }
                else if (name == "scoresFor1MinGame.txt")
                {
                    foreach (Player p in ListFor1MinGame)
                    {
                        writer.WriteLine(i + ". " + p);
                        i++;
                    }
                }
                else if (name == "scoresFor100TilesGame.txt")
                {
                    foreach (Player p in ListFor100Tiles)
                    {
                        writer.WriteLine(i + ". " + p);
                        i++;
                    }
                }
                else if (name == "scoresFor300TilesGame.txt")
                {
                    foreach (Player p in ListFor300Tiles)
                    {
                        writer.WriteLine(i + ". " + p);
                        i++;
                    }
                }
                
            }
             
        }

        private void loadResults()
        {
            if (File.Exists("scoresFor1MinGame.txt"))
            {
                using (StreamReader reader = new StreamReader("scoresFor1MinGame.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] part = line.Split(' ');
                        Player_Time p = new Player_Time(part[1], part[2], Convert.ToInt32(part[3]));
                        ListFor1MinGame.Add(p);
                    }
                }
            }
            if (File.Exists("scoresFor30SecGame.txt"))
            {
                using (StreamReader reader = new StreamReader("scoresFor30SecGame.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] part = line.Split(' ');
                        Player_Time p = new Player_Time(part[1], part[2], Convert.ToInt32(part[3]));
                        ListFor30SecGame.Add(p);
                    }
                }
            }
            if (File.Exists("scoresFor100TilesGame.txt"))
            {
                using (StreamReader reader = new StreamReader("scoresFor100TilesGame.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] part = line.Split(' ');
                        string name = part[1];
                        string surname = part[2];
                        string[] times = part[3].Split(':');
                        int sec = Convert.ToInt32(times[0]) * 60;
                        sec += Convert.ToInt32(times[1]);
                        Player_Tiles p = new Player_Tiles(name,surname,sec);
                        ListFor100Tiles.Add(p);
                    }
                }
            }
            if (File.Exists("scoresFor300TilesGame.txt"))
            {
                using (StreamReader reader = new StreamReader("scoresFor300TilesGame.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] part = line.Split(' ');
                        string name = part[1];
                        string surname = part[2];
                        string[] times = part[3].Split(':');
                        int sec = Convert.ToInt32(times[0]) * 60;
                        sec += Convert.ToInt32(times[1]);
                        Player_Tiles p = new Player_Tiles(name, surname, sec);
                        ListFor300Tiles.Add(p);
                    }
                }
            }

            ListFor100Tiles.Sort();
            ListFor300Tiles.Sort();
            ListFor30SecGame.Sort();
            ListFor1MinGame.Sort();
        }
    }
}
