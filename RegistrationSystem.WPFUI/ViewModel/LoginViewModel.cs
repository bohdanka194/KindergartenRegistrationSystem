using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using RegistrationSystem.Entities;
using System.Windows;
using RegistrationSystem.Common.UnitOfWork;

namespace RegistrationSystem.WPFUI.ViewModel
{
    public class LoginViewModel
    {
        public Action CloseAction { get; set; }

        private UnitOfWork _unitOfWork = new UnitOfWork();
        //private IEnumerable<User> users;
        public string Login { get; set; }
        public string Password { get; set; }

        private ICommand _loginCommand;
        private ICommand _registrationCommand;


        public ICommand LoginCommand
        {
            get
            {
                return _loginCommand ?? (_loginCommand = new RelayCommand((() =>
                {

                    if (IsUserExist(Login, Password))
                    {
                        var mainWindow = new MainWindow(Login);
                        mainWindow.Show();
                        CloseAction();
                    }
                    else
                    {
                        MessageBox.Show("User does not exist");
                    }
                    
                })));
            }

            set { _loginCommand = value; }
        }

        public ICommand RegistrationCommand
        {
            get
            {
                return _registrationCommand ?? (_registrationCommand = new RelayCommand((() =>
                {
                    var regVindow = new RegistrationWindow();
                    regVindow.Show();
                    CloseAction();

                })));
            }
            set { _registrationCommand = value; }
        }

        public ICommand CloseCommand
        {
            get
            {
                return new RelayCommand((() =>
                {
                    Application.Current.Shutdown();

                }));
            }

        }

        private bool IsUserExist(string login, string password)
        {

            password = Encrypt.GenerateHash(password, login);

            return _unitOfWork.IsUserExistInBase(login, password);
        }
    }
}