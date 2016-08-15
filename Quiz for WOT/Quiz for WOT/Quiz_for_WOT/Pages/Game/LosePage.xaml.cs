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
    public partial class LosePage : ContentPage
    {
        public LosePage()
        {

            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
            InitializeComponent();
            LabelTitle.Text = AppResources.PageLoseTitle;
            LabelToMenu.IsVisible = false;
            LabelToMenu.Text = AppResources.NavigationToMenu;
            LabelToMenu.IsVisible = true;
        }

        private void GoToMenuButton(object sender, EventArgs e)
        {
            Application.Current.MainPage = new RootPage();
        }
    }
}
