using Acr.UserDialogs;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace pract2_mobile.ViewModels
{
    public class RegistrationViewModel : BaseViewModel
    {
        private string name;
        private string email;
        private string password;
        private string passwordCheck;


        public string NameBox
        {
            get { return this.name; }
            set { SetValue(ref this.name, value); }
        }
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

        public string PasswordCheckBox
        {
            get { return this.passwordCheck; }
            set { SetValue(ref this.passwordCheck, value); }
        }

        public ICommand RegisterCommand
        {
            get { return new RelayCommand(Register); }
        }

        
        private void Register()
        {
            if (string.IsNullOrWhiteSpace(NameBox) || string.IsNullOrWhiteSpace(EmailBox) || string.IsNullOrWhiteSpace(PasswordBox) || string.IsNullOrWhiteSpace(PasswordCheckBox))
            {
                UserDialogs.Instance.Toast("No pueden haber campos vacíos.", TimeSpan.FromSeconds(3));
            }
            else
            {
                UserDialogs.Instance.Toast($"Ha sido registrado con Exito!", TimeSpan.FromSeconds(3));
            }
        }
    }
}
