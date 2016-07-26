using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiz_for_WOT.Resx;
using Quiz_for_WOT.ViewModel;
using Xamarin.Forms;

namespace Quiz_for_WOT.Pages.Game
{
    public partial class GamePage : ContentPage
    {
        public GamePage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            ButtonGiveMoney.Text = AppResources.PageGameGetMoney;
            BindingContext = new GameViewModel(this.Navigation);
        }
    }
}
