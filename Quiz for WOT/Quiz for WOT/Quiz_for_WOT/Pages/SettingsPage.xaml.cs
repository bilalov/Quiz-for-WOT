using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiz_for_WOT.Data;
using Quiz_for_WOT.Helpers;
using Quiz_for_WOT.Pages.MasterDetail;
using Quiz_for_WOT.Resx;
using Xamarin.Forms;

namespace Quiz_for_WOT.Pages
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
            Title = AppResources.SettingsPageTitle;
            PickerLanguage.Title = AppResources.SettingsPageLanguage;
            PickerLanguage.Items.Add("Russian");
            PickerLanguage.Items.Add("English");
            PickerLanguage.SelectedIndexChanged += (sender, args) =>
            {
                if (PickerLanguage.SelectedIndex == -1)
                {
                    
                }
                else
                {
                   /* string colorName = PickerLanguage.Items[PickerLanguage.SelectedIndex];
                    if (colorName == "Russian")
                    {
                        App.ScoreManager.Language = 1;
                        AppResources.Culture = new CultureInfo("ru-Ru");
                    }
                    else if(colorName=="English")
                    {
                        App.ScoreManager.Language = 2;
                        AppResources.Culture = new CultureInfo("en-US");
                    }*/
                   
                    
                }
            };
            buttonSave.Text = AppResources.Save;
            buttonSave.Clicked += (sender, args) =>
            {
                string colorName = PickerLanguage.Items[PickerLanguage.SelectedIndex];
                if (colorName == "Russian")
                {
                    App.ScoreManager.Language = 1;
                    AppResources.Culture = new CultureInfo("ru-Ru");
                }
                else if (colorName == "English")
                {
                    App.ScoreManager.Language = 2;
                    AppResources.Culture = new CultureInfo("en-US");
                }
                new StatisticsStore().Unload(App.ScoreManager);
                Application.Current.MainPage = new RootPage(MenuType.SettingsPage);
            };
        }
    }
}
