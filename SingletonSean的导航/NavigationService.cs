using Microsoft.Extensions.DependencyInjection;
using SingletonSean的导航.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSean的导航
{
    public class NavigationService
    {
		private ViewModelBase? currentViewModel;

		public ViewModelBase? CurrentViewModel
        {
			get { return currentViewModel; }
			set { 
				currentViewModel = value;

			}
		}

		public event Action? CurrentViewModelChanged;

		public void NavigateTo<T>() where T : ViewModelBase
			=> CurrentViewModel = App.Current.Services.GetService<T>();

    }
}
