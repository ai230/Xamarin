using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BombGame
{
    public partial class TotalScoreRanking : ContentPage
    {
        List<Player> rankingList;
        int count = 1;
        public TotalScoreRanking()
        {
            InitializeComponent();

            CreateData();
			
            myListView.ItemsSource = rankingList;
        }

        void CreateData()
        {
			rankingList = new List<Player>
			{
				new Player(6, "Elika", 5),
				new Player(2, "Bob", 1),
				new Player(3, "Emilie", 3),
				new Player(4, "Sam", 7),
				new Player(5, "Yoko", 3)
			};
            rankingList.Add(BombGamePage.me);
            rankingList.Sort();

			foreach (var player in rankingList)
			{
				player.RankingNum = count;
				count++;
			}
			count = 1;

        }
        void Update_Clicked(object sender, System.EventArgs e)
        {
            CreateData();
            rankingList.Sort();
            myListView.ItemsSource = rankingList;
        }
    }
}
