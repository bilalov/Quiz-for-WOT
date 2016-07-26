using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiz_for_WOT.Resx;
using Xamarin.Forms;

namespace Quiz_for_WOT.Pages
{
    public partial class InputAppPage : ContentPage
    {
        public InputAppPage()
        {
            InitializeComponent();
            Title = AppResources.AppName;
            LabelAppHello.Text = AppResources.AppHello;
        }
    }
}
