using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSean的导航.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        private readonly NavigationService navigator;

        [ObservableProperty]
        private ViewModelBase? currentViewModel;

        public MainViewModel(NavigationService navigationService)
        {
            navigator = navigationService;

            navigator.CurrentViewModelChanged += () =>
            {
                CurrentViewModel = navigationService.CurrentViewModel;
            };

            // navigate to login page at first
            navigator.NavigateTo<LoginViewModel>();
        }
    }
}
