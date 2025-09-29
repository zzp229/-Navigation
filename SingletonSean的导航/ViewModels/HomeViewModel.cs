using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSean的导航.ViewModels
{
    public partial class HomeViewModel : ViewModelBase
    {
        private readonly NavigationService navigationService;
        private readonly UserService userService;

        [ObservableProperty]
        string? userName;

        public HomeViewModel(NavigationService navigationService, UserService userService)
        {
            this.navigationService = navigationService;
            this.userService = userService;
            UserName = userService.UserName;
        }

        [RelayCommand]
        void Logout()
        {
            // navigate back to login page
            userService.UserName = null;
            navigationService.NavigateTo<LoginViewModel>();
        }
    }
}
