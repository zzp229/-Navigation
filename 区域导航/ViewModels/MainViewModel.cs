using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 区域导航.Views;

namespace 区域导航.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        [ObservableProperty]
        ApplicationPage currentPage;


        public MainViewModel()
        {
            
        }



    }
}
