using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BombGame
{
    public partial class Tabbed : TabbedPage
    {
      
        public Tabbed()
        {
            InitializeComponent();
            //BarBackgroundColor = Color.FromHex(barColor);
            //BarTextColor = Color.White;

            var tab1 = new NavigationPage(new BombGamePage());
			tab1.Title = "My Game";
            //tab1.BarBackgroundColor = Color.FromHex(barColor);
            //tab1.BarTextColor = Color.Black;
			this.Children.Add(tab1);

			var tab2 = new NavigationPage(new TotalScoreRanking());
			tab2.Title = "Ranking";
            //tab2.BarBackgroundColor = Color.FromHex(barColor);
			this.Children.Add(tab2);

        }
    }
}
