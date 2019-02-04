using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace XamarinTriggers
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        private string _name;
        private string _surname;

        public string Name 
        { 
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(); 
            }
        }

        public string Surname
        {
            get { return _surname; }
            set
            {
                _surname = value;
                OnPropertyChanged();
            }
        }

        public MainPage()
        {
            Name = string.Empty;
            Surname = string.Empty;

            InitializeComponent();
            BindingContext = this;
        }
    }
}
