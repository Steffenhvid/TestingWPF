using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TestingWPF.ViewModels;

namespace TestingWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider Services { get; }
        public new static App Current => (App)Application.Current;
        public App()
        {
            Services = CongifureServices();
        }

        public static IServiceProvider CongifureServices()
        {
            var services = new ServiceCollection();

            //Add services here
            services.AddTransient<MainViewModel>();

            return services.BuildServiceProvider();
        }
    }
}
