using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quiz_for_WOT.Interfaces;
using Quiz_for_WOT.Pages.MasterDetail;
using Quiz_for_WOT.Resx;
using Xamarin.Forms;

namespace Quiz_for_WOT
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var netLanguage = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            AppResources.Culture = netLanguage;

            MainPage = new RootPage();


        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
