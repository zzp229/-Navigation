using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSean的导航.ViewModels
{
    public partial class LoginViewModel : ViewModelBase
    {
        private readonly NavigationService navigationService;
        private readonly UserService userService;

        [ObservableProperty]
        string? userName = "Sean";

        public LoginViewModel(NavigationService navigationService, UserService userService)
        {
            this.navigationService = navigationService;
            this.userService = userService;
        }

        [RelayCommand]
        void Login()
        {
            // navigate to home page
            userService.UserName = UserName;
            navigationService.NavigateTo<HomeViewModel>();
        }
    }
}
