using System;
using Xamarin.Forms;

namespace BombGame
{
    public partial class BombGamePage : ContentPage
    {
        public static Player me;
		int bomb;
        //bool playing = true;
        int score = 0;

        public BombGamePage()
        {
            InitializeComponent();
            scoreLabel.Text = score.ToString();
            GetRandomNumber();
            me = new Player(1, "Ai");
        }

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			Button button = sender as Button;
            Label label = sender as Label;

			if (button.Text == bomb.ToString())
			{
                titleLabel.Text = "GAME OVER";
                me.TotalScore = score;
				await DisplayAlert("Bomb Exploded", "Game Over", "OK");
               
                score = 0;
				GetRandomNumber();

			}
            else
            {
                button.BackgroundColor = Color.FromHex("#E3E0CF");
                score++;
                scoreLabel.Text = score.ToString();
            }

		}

		private void GetRandomNumber()
		{
			bomb = new Random().Next(1, 9);
		}

        void RestartButton_Clicked(object sender, System.EventArgs e)
        {
            InitializeComponent();
            score = 0;
            scoreLabel.Text = score.ToString();
            GetRandomNumber();

		}
    }

}
