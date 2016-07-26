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
                    new HomeMenuItem { Title = "InputPage", MenuType = MenuType.InputPage, Icon = "icon.png"},
                   
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
