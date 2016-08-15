using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Quiz_for_WOT.Data;
using Quiz_for_WOT.Helpers;
using Quiz_for_WOT.Interfaces;
using Quiz_for_WOT.Pages.MasterDetail;
using Quiz_for_WOT.Resx;
using Quiz_for_WOT.ViewModel;
using Xamarin.Forms;

namespace Quiz_for_WOT
{
    public partial class App : Application
    {
        private static ViewModelLocator _locator;
        public static ScoreManager ScoreManager { get; set; }

        public static ViewModelLocator Locator
        {
            get
            {
                return _locator ?? (_locator = new ViewModelLocator());
            }
        }

        public App()
        {
            FileHelper fileHelper = new FileHelper();
            if (!fileHelper.Exists(StatisticsStore.filename))
            {
                StatisticsStore statisticsStore = new StatisticsStore();
                ScoreManager scoreManager = new ScoreManager();
                statisticsStore.Unload(scoreManager);
            }

            ScoreManager = new StatisticsStore().Load();

            if (ScoreManager.Language != 0)
            {
                if (ScoreManager.Language==1)
                {
                    AppResources.Culture = new CultureInfo("ru-Ru");
                }
                else if (ScoreManager.Language==2)
                {
                    AppResources.Culture = new CultureInfo("en-US");
                }
            }
            else
            {
                var netLanguage = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
                AppResources.Culture = netLanguage;
            }

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
