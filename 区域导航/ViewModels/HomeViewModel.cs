using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 区域导航.ViewModels
{
    public partial class HomeViewModel : ViewModelBase
    {
        [RelayCommand]
        void Logout()
        {
            NavigationService.Instance.Navigate(Views.ApplicationPage.Login);
        }
    }
}
