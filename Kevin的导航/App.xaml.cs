using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Kevin的导航
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider Services { get; }

        public static new App Current => (App)Application.Current;

        public App()
        {
           var container = new ServiceCollection();
           container.AddSingleton<MainWindow>();
            container.AddTransient<MainViewModel>();
            
            container.AddScoped<Page1ViewModel>();
            container.AddScoped<Page2ViewModel>();
            container.AddScoped<Page3ViewModel>();

            Services = container.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow = Services.GetRequiredService<MainWindow>();
            MainWindow.Show();
        }
    }

}
