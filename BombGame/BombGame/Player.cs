using System;
namespace BombGame
{
    public class Player : IComparable
    {
        public int RankingNum { set; get; }
        public int ID { set; get; }
        public string Name { set; get; }
        public int TotalScore { set; get; }
        public string ImageUrl { set; get; }

        private string path = "http://lorempixel.com/200/200/people/";

        public Player(int id, string name, int totalScore)
        {
            this.ID = id;
            this.Name = name;
            this.TotalScore = totalScore;
            this.ImageUrl = path + id.ToString();
        }

        public Player(int id, string name)
        {
            this.ID = id;
            this.Name = name;
            this.ImageUrl = path + id.ToString();
        }

        //Sort
        public int CompareTo(object obj)
        {
            Player playerToCompare = obj as Player;
            if(playerToCompare.TotalScore < TotalScore)
            {
                return -1;
            }
            else if(playerToCompare.TotalScore > TotalScore)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
}
