using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiz_for_WOT.Helpers;
using Quiz_for_WOT.Model.MasterDetailPage;
using Quiz_for_WOT.Resx;
using Xamarin.Forms;

namespace Quiz_for_WOT.Pages.MasterDetail
{
    public partial class MenuPage : ContentPage
    {
        RootPage root;
        List<HomeMenuItem> menuItems;
        public MenuPage(RootPage root)
        {

            this.root = root;
            InitializeComponent();

            BackgroundColor = Color.FromHex("#795548");
            BindingContext = new BaseViewModel
            {
                Title = "Menu",
                Subtitle = " ",
                Icon = "icon.png"
            };

            ListViewMenu.ItemsSource = menuItems = new List<HomeMenuItem>
                {
                    new HomeMenuItem { Title = AppResources.MenuAboutApp, MenuType = MenuType.About, Icon = "icon.png"},
                    new HomeMenuItem { Title = AppResources.MenuGame, MenuType = MenuType.Game, Icon = "handofdeath.png"},
                    new HomeMenuItem { Title = AppResources.MenuStatictics, MenuType = MenuType.Statistics, Icon = "medalleclerc2.png" },
                    new HomeMenuItem { Title = AppResources.MenuAboutApp, MenuType = MenuType.AboutApp, Icon ="sturdy.png" },
                };

            ListViewMenu.SelectedItem = menuItems[0];

            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (ListViewMenu.SelectedItem == null)
                    return;

                await this.root.NavigateAsync(((HomeMenuItem)e.SelectedItem).MenuType);
            };
        }
    }
}
