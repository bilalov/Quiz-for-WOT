using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiz_for_WOT.Pages.MasterDetail;
using Quiz_for_WOT.Resx;
using Xamarin.Forms;

namespace Quiz_for_WOT.Pages.Game
{
    public partial class WinPage : ContentPage
    {
        public WinPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
            InitializeComponent();

            LabelTitle.Text = AppResources.PageWinGameTitle;
            LabelToMenu.Text = AppResources.NavigationToMenu;
            LabelGetMoney.Text = AppResources.PageGameGetMoney;
        }

        private void GoToMenuButton(object sender, EventArgs e)
        {
            /*  if (Device.OS == TargetPlatform.iOS) {
                 await Navigation.PopToRootAsync ();
             }
             Application.Current.MainPage = new MainPage ();*/
            Application.Current.MainPage = new RootPage();
        }
    }
}
