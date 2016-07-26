using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace Quiz_for_WOT.ViewModel
{
    public class ViewModelLocator
    {
        public const string AboutPage = "AboutPage";
        public const string MenuPage = "MenuPage";
        public const string CopyrightPage = "CopyrightPage";
        public const string GamePage = "GamePage";
        public const string LosePage = "LosePage";

        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<GameViewModel>();
            SimpleIoc.Default.Register<StatisticsViewModel>();
        }

       

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
           "CA1822:MarkMembersAsStatic",
           Justification = "This non-static member is needed for data binding purposes.")]
        public GameViewModel Game
        {
            get
            {
                return ServiceLocator.Current.GetInstance<GameViewModel>();
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
           "CA1822:MarkMembersAsStatic",
           Justification = "This non-static member is needed for data binding purposes.")]
        public StatisticsViewModel Profile
        {
            get
            {
                if (!SimpleIoc.Default.ContainsCreated<StatisticsViewModel>())
                    SimpleIoc.Default.Register<StatisticsViewModel>();

                return ServiceLocator.Current.GetInstance<StatisticsViewModel>();
            }
        }
    }
}
