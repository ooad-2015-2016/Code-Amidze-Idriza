using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AutoSkola.Autoskola.Helpers;
using Windows.UI.Xaml.Controls;
using AutoSkola.Autoskola.Views;

namespace AutoSkola.Autoskola.ViewModels
{
    class PrijavaViewModel
    {
        public String email { get; set; }
        public String password { get; set; }
        public ICommand LoginUser { get; set; }
        public INavigacija NavigationServis { get; set; }
        public PrijavaViewModel()
        {
            NavigationServis = new NavigationService();
            email = "";
            password = "";
            LoginUser = new RelayCommand<object>(login);

        }
        private async void login(object parametar)
        {
            var UnosPassBox = parametar as PasswordBox;
            password = UnosPassBox.Password;

            NavigationServis.Navigate(typeof(MainPage), null);

        }
    }
}
