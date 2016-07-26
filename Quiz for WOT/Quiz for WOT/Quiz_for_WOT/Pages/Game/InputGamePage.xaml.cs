using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiz_for_WOT.Resx;
using Xamarin.Forms;

namespace Quiz_for_WOT.Pages.Game
{
    public partial class InputGamePage : ContentPage
    {
        public InputGamePage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            LabelStartGame.Text = AppResources.PageGameStart;

            delay();
        }


        private async void delay()
        {
            await Task.Delay(1000);
            GoGame();
        }

        private void GoGame()
        {
            App.Current.MainPage = new NavigationPage(new GamePage());
        }
    }
}
