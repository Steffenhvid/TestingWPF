using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TestingWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider Services { get; }
        public App()
        {
            Services = CongifureServices();
        }

        public static IServiceProvider CongifureServices()
        {
            var services = new ServiceCollection();

            //Add services here

            return services.BuildServiceProvider();
        }
    }
}
