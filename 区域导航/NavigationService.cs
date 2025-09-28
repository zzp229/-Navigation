using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 区域导航.ViewModels;
using 区域导航.Views;

namespace 区域导航
{
    public class NavigationService
    {
        public static NavigationService Instance { get; } = new NavigationService();

        private MainViewModel mainVM;

        public void Navigate(ApplicationPage page)
        {
            if (mainVM == null)
            {
                mainVM = (MainViewModel)App.Current.MainWindow.DataContext;
            }

            mainVM.CurrentPage = page;
        }
    }
}
