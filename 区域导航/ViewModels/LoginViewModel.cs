using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 区域导航.ViewModels
{
    public partial class LoginViewModel : ViewModelBase
    {
        public string UserName { get; set; } = "登录页面";

        [RelayCommand]
        void Login()
        {
            // 登录逻辑
            NavigationService.Instance.Navigate(Views.ApplicationPage.Home);
        }
    }
}
