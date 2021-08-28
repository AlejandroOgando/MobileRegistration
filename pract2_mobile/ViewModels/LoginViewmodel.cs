using Acr.UserDialogs;
using GalaSoft.MvvmLight.Command;
using pract2_mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace pract2_mobile.ViewModels
{
    public class LoginViewmodel : BaseViewModel
    {
        private string email;
        private string password;

        public string EmailBox
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }

        public string PasswordBox
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }

        public ICommand LoginCommand
        {
            get { return new RelayCommand(Login); }
        }


        private void Login()
        {
            if (string.IsNullOrWhiteSpace(EmailBox) || string.IsNullOrWhiteSpace(PasswordBox))
            {
                UserDialogs.Instance.Toast("No pueden haber campos vacíos.", TimeSpan.FromSeconds(3));
            }
            else
            {
                UserDialogs.Instance.Toast($"Bienvenido, {EmailBox}", TimeSpan.FromSeconds(3));
            }
        }

        public ICommand RegisterNavCommand
        {
            get { return new RelayCommand(RegisterNav); }
        }

        private async void RegisterNav()
        {
            var registrationPage = new RegistrationPage();
            await App.Current.MainPage.Navigation.PushAsync(registrationPage);
            //await Application.Current.MainPage.Navigation.PushAsync(registrationPage);
        }
    }
}
