using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingWPF.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private string title;

        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }

        public MainViewModel()
        {
            SetTexts();
        }

        private void SetTexts()
        {
            Title = "Application Title";
        }
    }
}
