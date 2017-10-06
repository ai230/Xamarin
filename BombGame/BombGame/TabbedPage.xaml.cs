using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BombGame
{
    public partial class MyTabbedPage : TabbedPage
    {
        public MyTabbedPage()
        {
            InitializeComponent();

            var tab1 = new NavigationPage(new BombGame());
            tab1.Title = "My Game";
            this.Children.Add(tab1);

			var tab2 = new NavigationPage(new TotalScoreRanking());
			tab2.Title = "Ranking";
			this.Children.Add(tab2);
        }
    }
}
