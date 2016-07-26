using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiz_for_WOT.Resx;
using Xamarin.Forms;

namespace Quiz_for_WOT.Pages
{
    public partial class CommonStatisticsPage : ContentPage
    {
        public CommonStatisticsPage()
        {
            InitializeComponent();
            BindingContext = App.Locator.Profile;
            LabelGlobalRecord.Text = AppResources.PageStatisticsGlobalRating;
            LabelRecords.Text = AppResources.PageStatisticsLabelRecords;
            Title = AppResources.PageStatisticsTitle;
        }
    }
}
