using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiz_for_WOT.Resx;
using Xamarin.Forms;

namespace Quiz_for_WOT.Pages.About
{
    public partial class CopyrightPage : ContentPage
    {
        public CopyrightPage()
        {
            Title = AppResources.MenuCopyright;
            InitializeComponent();
            LabelCopyrightText.Text = AppResources.PageCopyrightText;
        }
    }
}
