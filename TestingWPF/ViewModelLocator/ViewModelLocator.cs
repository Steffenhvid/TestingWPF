using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingWPF.ViewModels;

namespace TestingWPF.ViewModelLocator
{
    public class ViewModelLocator
    {
        public MainViewModel mainViewModel => App.Current.Services.GetService<MainViewModel>();
    }
}
