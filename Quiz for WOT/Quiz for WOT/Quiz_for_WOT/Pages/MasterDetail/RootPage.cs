using System.Collections.Generic;
using System.Threading.Tasks;
using Quiz_for_WOT.Model;
using Quiz_for_WOT.Controls;
using Quiz_for_WOT.Helpers;
using Quiz_for_WOT.Model.MasterDetailPage;
using Quiz_for_WOT.Pages.About;
using Quiz_for_WOT.Pages.Game;
using Quiz_for_WOT.Pages.MasterDetail;
using Xamarin.Forms;

namespace Quiz_for_WOT.Pages.MasterDetail
{
    public class RootPage : MasterDetailPage
    {
        Dictionary<MenuType, NavigationPage> Pages { get; set; }
        public RootPage()
        {
            
            Pages = new Dictionary<MenuType, NavigationPage>();
            Master = new MenuPage(this);
            BindingContext = new BaseViewModel
            {
                Title = "dfs",
                Icon = "icon.png"
            };
            //setup home page
            NavigateAsync(MenuType.InputPage);
            InvalidateMeasure();
        }

        public RootPage(MenuType menuType)
        {

            Pages = new Dictionary<MenuType, NavigationPage>();
            Master = new MenuPage(this);
            BindingContext = new BaseViewModel
            {
                Title = "fds",
                Icon = "icon.png"
            };
            //setup home page
            NavigateAsync(menuType);
            InvalidateMeasure();
        }


        public async Task NavigateAsync(MenuType id)
        {
            Page newPage;
            if (!Pages.ContainsKey(id))
            {

                switch (id)
                {
                    case MenuType.InputPage:
                        Pages.Add(id, new HanselmanNavigationPage(new InputAppPage()));
                        break;
                    case MenuType.AboutApp:
                        Pages.Add(id, new HanselmanNavigationPage(new AboutTabbedPage()));
                        break;
                    case MenuType.Statistics:
                        Pages.Add(id, new HanselmanNavigationPage(new CommonStatisticsPage()));
                        break;
                    case MenuType.Game:
                        Pages.Add(id, new HanselmanNavigationPage(new InputGamePage()));
                        break;
                }
            }

            newPage = Pages[id];
            if (newPage == null)
                return;

            Detail = newPage;

            if (Device.Idiom != TargetIdiom.Tablet)
                IsPresented = false;
        }
    }
}
